using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DespachoAutomatico
{
    [DataContract]
    class consultar_viaje_info
    {
        [DataMember]
        public string id { get; set; }

        [DataMember]
        public string dir_origen{ get; set; }
        
        [DataMember]
        public string latitud_origen{ get; set; }
        
        [DataMember]
        public string longitud_origen{ get; set; }
        
        [DataMember]
        public string dir_destino{ get; set; }
        
        [DataMember]
        public string latitud_destino{ get; set; }
        
        [DataMember]
        public string longitud_destino{ get; set; }
        
        [DataMember]
        public string localidad{ get; set; }
        
        [DataMember]
        public string tarifa{ get; set; }
        
        [DataMember]
        public string distancia{ get; set; }
        
        [DataMember]
        public string fecha{ get; set; }
        
        [DataMember]
        public string hora{ get; set; }
        
        [DataMember]
        public string observaciones{ get; set; }
        
        [DataMember]
        public string estado{ get; set; }
        
        [DataMember]
        public string cercanos{ get; set; }
        
        [DataMember]
        public string vehiculo_id{ get; set; }
        
        [DataMember]
        public string conductor_id{ get; set; }
        
        [DataMember]
        public string empresa_id{ get; set; }

        [DataMember]
        public string usuario_id{ get; set; }
        
        [DataMember]
        public string ivr_domicilio{ get; set; }
        
        [DataMember]
        public string creador{ get; set; }

        [DataMember]
        public string nro_registro { get; set; }

        [DataMember]
        public string patente { get; set; }
    
    }
}
