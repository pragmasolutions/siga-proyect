using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apipe;
using entitiesApipe;
using MySql.Data;


namespace DespachoAutomatico
{
    public partial class FrmDespachoAutomatico : Form
    {
        private ClsAdministrarPedidos cls = new ClsAdministrarPedidos();
        ClsClientes clspedido = new ClsClientes();
        ClsDespachador clsDespachador = new ClsDespachador();
        
        
        public FrmDespachoAutomatico()
        {
            InitializeComponent();
        }

#region Metodos

        private void RefrescarGrilla()
        {
            try
            {
                cls.CargarPedidosIVR();
                DgvPedidos.DataSource = cls.lstPedido;
                LblIVR.Text = cls.lstPedido.Count().ToString();

                cls.CargarPedidosCQV();
                DgvCQV.DataSource = cls.lstPedidoCQV;
                LblCQV.Text = cls.lstPedidoCQV.Count().ToString();

                cls.CargarPedidosApipe();
                DgvApipe.DataSource = cls.lstPedidoApipe;
                LblApipe.Text = cls.lstPedidoApipe.Count().ToString();
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Enviar Pedido al sistema de Con Quien Viajo
        private void EnviarPedido()
        {
            if (cls.lstPedido.Any())
            {
                foreach (pedido pedido in cls.lstPedido)
                {
                    string domicilio = pedido.v_domicilioCQV;
                    string borrar = "IVR, MAXIMA PRIORIDAD";
                    string observaciones = pedido.v_domicilioCQV + ' ' + pedido.v_observacionesCQV + ' ' + pedido.observacion.Replace(borrar, " ") +
                        pedido.v_clienteAyN;
                    
                    //string observaciones = pedido.v_observacionesCQV + ' ' + pedido.observacion.Replace(borrar, " ") +
                    //    pedido.v_clienteAyN;
                   
                    if (domicilio != "")
                    {
                        if (pedido.v_EstadoDomicilio == "Valido")
                        {
                            GenerarViaje(domicilio, observaciones, pedido.id);
                        }
                        else if (pedido.v_EstadoDomicilio == "Validar")
                        {
                            if (ValidarDomicilio(domicilio, pedido.domicilio_id))
                            {
                                GenerarViaje(domicilio, observaciones, pedido.id);
                            }
                            else
                            {
                                pedido.Estado = "Pendiente_Apipe";
                                cls.ModificarEstadoPedido(pedido.id, 0, pedido.Estado);
                            }
                        }
                        else
                        {
                            pedido.Estado = "Pendiente_Apipe";
                            cls.ModificarEstadoPedido(pedido.id, 0, pedido.Estado);
                        }
                    }
                    else
                    {
                          pedido.Estado = "Pendiente_Apipe";
                          cls.ModificarEstadoPedido(pedido.id, 0, pedido.Estado);
                    }
               }
            }
        }

        private bool ValidarDomicilio(string domicilio, int domicilio_id)
        {
            bool estado = false;
            int estadoId=0;

            if(AnalizarContador() > 1500)
            {
                return estado;
            }

            try
            {
                string url =
                   "http://maps.googleapis.com/maps/api/geocode/json?sensor=false&language=ES&address=" +
                   domicilio + ",Corrientes,Corrientes";
                WebRequest request = WebRequest.Create(url);
                WebResponse ws = request.GetResponse();

                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Validacion));
                Validacion validacion = (Validacion)jsonSerializer.ReadObject(ws.GetResponseStream());

                clsDespachador.ActualizarContador(clsDespachador.contador.id);

                if (validacion != null)
                {
                    if (validacion.status == "OK" && validacion.results.First().types.First() == "street_address")
                    {
                        estado= true;
                        estadoId = 1;
                    }
                    else
                    {
                        estado=false;
                        estadoId = 2;
                    }
                    //GUARDAR ESTADO DE VALIDACION
                    clspedido.ActualizarEstadoDomicilio(domicilio_id,estadoId);
                }
                return estado;
            }
            catch (Exception)
            {
                estado= false;
                return estado;
            }

        
        }

        private int AnalizarContador()
        {
            clsDespachador.FillUltimo();
            int contador = 2500;

            if (clsDespachador.contador.fechainicio < DateTime.Now && clsDespachador.contador.contador <= 1500)
            {
                if(clsDespachador.contador.fechainicio.AddDays(1) < DateTime.Now)
                {
                    clsDespachador.CerrarContador(clsDespachador.contador.id);
                    clsDespachador.NuevoContador(clsDespachador.contador.fechainicio.AddDays(1));
                }
                contador = clsDespachador.contador.contador;
                
            }
            else
            {
                if (clsDespachador.contador.contador > 1500)
                {
                    clsDespachador.CerrarContador(clsDespachador.contador.id);
                    clsDespachador.NuevoContador(clsDespachador.contador.fechainicio.AddDays(1));
                }
                
            }

            return contador;
        }

        private void GenerarViaje(String direccion, String comentario, int IdPedidoApipe)
        {
            try
            {
                //test
                //string url =
                //"http://apptaxiwstesting-cqvtesting.rhcloud.com/apipe/crear_viaje.php?Clave=ApipeCQV@2015&Direccion=" +
                //direccion + ", Corrientes, Argentina" + "&Observaciones="+ comentario;

                //Produccion
                string url =
                "http://apptaxiwebservices-quboo.rhcloud.com/apipe/crear_viaje.php?Clave=ApipeCQV@2015&Direccion=" +
                direccion + ", Corrientes, Argentina" + "&Observaciones="+ comentario;


                WebRequest request = WebRequest.Create(url);
                WebResponse ws = request.GetResponse();

                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(CrearViaje));
                CrearViaje viaje = (CrearViaje)jsonSerializer.ReadObject(ws.GetResponseStream());
            
                if (viaje.idViaje > 0)
                {
                    //Se generó el pedido en CQV
                    cls.ModificarEstadoPedido(IdPedidoApipe, viaje.idViaje, "Pendiente");
                }
                else
                {
                    //No se generó el pedido por falta de autos en CQV
                    cls.ModificarEstadoPedido(IdPedidoApipe, viaje.idViaje, "Cancelado_sistema_no_disponible");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void Consultar_info_viajes()
        {

            try
            {
                //Test
                //string url =
                //    "http://apptaxiwstesting-cqvtesting.rhcloud.com/apipe/consultar_info_viajes.php?Clave=ApipeCQV@2015";

                //Produccion
                string url =
                    "http://apptaxiwebservices-quboo.rhcloud.com/apipe/consultar_info_viajes.php?Clave=ApipeCQV@2015";

                WebRequest request = WebRequest.Create(url);
                WebResponse ws = request.GetResponse();

                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<consultar_viaje_info>));
                List<consultar_viaje_info> lstviajes = (List<consultar_viaje_info>)jsonSerializer.ReadObject(ws.GetResponseStream());

                foreach (consultar_viaje_info consultarViajeInfo in lstviajes)
                {
                    //Buscar si existe el viaje en nuestra base y actualizar el estado
                    int idcqv;
                    cls.FillPedidoByCQV(int.TryParse(consultarViajeInfo.id, out idcqv) ? idcqv : idcqv);

                    if (cls.lstInfoPedidoCQV.Any())
                    {
                        //El pedido ya esta en nuestra base - Actualizar el estado
                        if(cls.lstInfoPedidoCQV.First().Estado!="Enviado_Apipe")
                        {
                            cls.ModificarEstadoPedido(cls.lstInfoPedidoCQV.First().id, cls.lstInfoPedidoCQV.First().IdCQV, consultarViajeInfo.estado);
                            int pedidoid = cls.lstInfoPedidoCQV.First().id;
                            int movil;
                            ActualizarEstado(pedidoid, consultarViajeInfo.estado, int.TryParse(consultarViajeInfo.nro_registro, out movil) ? movil : movil);
                        }
                        
                    }
                    else //Nuevo Pedido
                    {

                        //Crear Domicilio
                        if (consultarViajeInfo.dir_origen == null)
                            clspedido.domicilio.calle = "PedidoCQV";
                        else
                        {
                            string[] domicilio = consultarViajeInfo.dir_origen.Split(',');
                            clspedido.domicilio.calle = domicilio[0];
                        }

                        clspedido.domicilio.tipo = "CASA";
                        clspedido.domicilio.barrio_id = 1;

                        clspedido.IniciarTrn();
                        try
                        {
                            clspedido.Preservardomicilio(clspedido.domicilio.calle, clspedido.domicilio.numero, clspedido.domicilio.tipo, clspedido.domicilio.descripcion, clspedido.domicilio.interseccion, clspedido.domicilio.observacion, clspedido.domicilio.barrio_id, clspedido.domicilio.zona_id, 1);
                            clspedido.gettrn.Commit();
                            clspedido.FillUltimoDomicilio();
                        }
                        catch (Exception)
                        {
                            clspedido.gettrn.Rollback();
                            throw;
                        }

                        //Generar un nuevo pedido en Apipe

                        clspedido.Pedido.cliente = "CQV";
                        clspedido.Pedido.fechahora = DateTime.Now;
                        clspedido.Pedido.fechahora_viaje = DateTime.Now;
                        clspedido.Pedido.asignado = DateTime.Now;
                        clspedido.Pedido.observacion = consultarViajeInfo.observaciones;
                        //clspedido.Pedido.usuario_id = 99023; //Usuario CQV 2909
                        clspedido.Pedido.usuario_id = 119045; //Usuario CQV
                        clspedido.Pedido.pedido_categoria_id = 7; //Pedido CQV
                        clspedido.Pedido.domicilio_id = clspedido.domicilio.id;
                        clspedido.Pedido.telefono_id = 1; //Crear uno para los que vengan de CQV

                        int codigo;
                        clspedido.Pedido.IdCQV = int.TryParse(consultarViajeInfo.id, out codigo) ? codigo : codigo; //Se agrego el idcqv
                        clspedido.Pedido.Estado = consultarViajeInfo.estado; //Se agrego el Estado
                        int movil = int.TryParse(consultarViajeInfo.nro_registro, out movil) ? movil : movil;

                        clspedido.IniciarTrn();
                        try
                        {
                            if (consultarViajeInfo.estado == "Pendiente")
                                clspedido.GenerarPedidoCQV(clspedido.Pedido.cliente, clspedido.Pedido.fechahora_viaje, clspedido.Pedido.observacion,
                                              clspedido.Pedido.usuario_id, clspedido.Pedido.pedido_categoria_id,
                                              clspedido.Pedido.domicilio_id, clspedido.Pedido.telefono_id, clspedido.Pedido.IdCQV, clspedido.Pedido.Estado, 0);
                            else
                                clspedido.GenerarPedidoCQV(clspedido.Pedido.cliente, clspedido.Pedido.fechahora_viaje, clspedido.Pedido.observacion,
                                                  clspedido.Pedido.usuario_id, clspedido.Pedido.pedido_categoria_id,
                                                  clspedido.Pedido.domicilio_id, clspedido.Pedido.telefono_id, clspedido.Pedido.IdCQV, clspedido.Pedido.Estado, movil);

                            clspedido.gettrn.Commit();
                            int idCqv;
                            int movilnumero;
                            cls.FillPedidoByCQV(int.TryParse(consultarViajeInfo.id, out idCqv) ? idCqv : idCqv);

                            ActualizarEstado(cls.lstInfoPedidoCQV.First().id, consultarViajeInfo.estado, int.TryParse(consultarViajeInfo.nro_registro, out movilnumero) ? movilnumero : movilnumero);

                        }
                        catch (Exception ex)
                        {
                            cls.gettrn.Rollback();
                            MessageBox.Show(ex.Message);
                        }
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void ActualizarEstado(int pedidoid, string estadoViaje, int movilnro)
        {
            ////Modificar el pedido
            if (estadoViaje == "Aceptado")
            {
                cls.AsignarPedidoCQV(pedidoid, movilnro);
            }
            else if (estadoViaje == "En_viaje")
            {
                //Si no se registro la asignación, regitrar
                if (cls.lstInfoPedidoCQV.First().asignado.Year == 1900)
                    cls.AsignarPedidoCQV(pedidoid, movilnro);
                //cls.CompletarPedido(pedidoid, 99023); //OperadorCQv 2909
                cls.CompletarPedidoCQV(pedidoid, 119045); //OperadorCQv
            }
            else if (estadoViaje == "Finalizado")
            {
                //Si no se registro la asignación y/o la completacion, registrar
                if (cls.lstInfoPedidoCQV.First().asignado.Year == 1900)
                    cls.AsignarPedidoCQV(pedidoid, movilnro);
               if (cls.lstInfoPedidoCQV.First().completado.Year == 1900)
                   //cls.CompletarPedido(pedidoid, 99023); //OperadorCQv2909
                   cls.CompletarPedidoCQV(pedidoid, 119045); //OperadorCQv
            }
            else if (estadoViaje == "Cancelado_sistema_no_disponible")
            {
                cls.LiberarPedidoCQV(pedidoid);
            }
            else if (estadoViaje == "Pasajero_ausente")
            {
                if (cls.lstInfoPedidoCQV.First().Estado!="Pasajero_ausente")
                    //clspedido.CancelarPedidoCQV(pedidoid, 99023,movilnro);//2909
                    clspedido.CancelarPedidoCQV(pedidoid, 119045, movilnro);//2909
            }
            else if (estadoViaje == "Pendiente")
            {
                TimeSpan timeSpan = DateTime.Now.Subtract(cls.lstInfoPedidoCQV.First().fechahora_viaje);
                if (timeSpan.Minutes > 3)
                    if (cls.lstInfoPedidoCQV.First().Estado == "Pendiente")
                        cls.ModificarEstadoPedido(cls.lstInfoPedidoCQV.First().id, cls.lstInfoPedidoCQV.First().IdCQV, "Pendiente_Apipe");
            }
        }

#endregion

        private void timer1_Tick(object sender, EventArgs e) //Consulta Estados
        {
            Consultar_info_viajes();
        }

        private void TimerEnvio_Tick(object sender, EventArgs e)
        {
            RefrescarGrilla();
            EnviarPedido();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }

        public void BtnCargarGrilla_Click(object sender, EventArgs e)
        {
            TimerEnvio.Start();
            timerConsultaEstados.Start();
        }
        
        private void BtnGenerarPedidos_Click(object sender, EventArgs e)
        {
            EnviarPedido();
        }
        
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Consultar_info_viajes();
        }

        private void FrmDespachoAutomatico_Load(object sender, EventArgs e)
        {

        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            if (AnalizarContador() < 1501)
            {
                clsDespachador.ActualizarContador(clsDespachador.contador.id);
            }
        }

       
        
	

    }
}
