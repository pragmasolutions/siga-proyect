namespace DespachoAutomatico
{
    partial class FrmDespachoAutomatico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.DgvPedidos = new Telerik.WinControls.UI.RadGridView();
            this.BtnCargarGrilla = new Telerik.WinControls.UI.RadButton();
            this.BtnGenerarPedidos = new Telerik.WinControls.UI.RadButton();
            this.BtnLogin = new Telerik.WinControls.UI.RadButton();
            this.TimerEnvio = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvCQV = new Telerik.WinControls.UI.RadGridView();
            this.DgvApipe = new Telerik.WinControls.UI.RadGridView();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.timerConsultaEstados = new System.Windows.Forms.Timer(this.components);
            this.LblIVR = new System.Windows.Forms.Label();
            this.LblCQV = new System.Windows.Forms.Label();
            this.LblApipe = new System.Windows.Forms.Label();
            this.BtnActualizar = new Telerik.WinControls.UI.RadButton();
            this.btnContador = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCargarGrilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGenerarPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCQV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCQV.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvApipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvApipe.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnContador)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPedidos
            // 
            this.DgvPedidos.AllowDrop = true;
            this.DgvPedidos.Location = new System.Drawing.Point(12, 38);
            // 
            // DgvPedidos
            // 
            this.DgvPedidos.MasterTemplate.AllowAddNewRow = false;
            this.DgvPedidos.MasterTemplate.AllowColumnReorder = false;
            this.DgvPedidos.MasterTemplate.AllowDeleteRow = false;
            this.DgvPedidos.MasterTemplate.AllowDragToGroup = false;
            this.DgvPedidos.MasterTemplate.AllowEditRow = false;
            this.DgvPedidos.MasterTemplate.AllowRowResize = false;
            this.DgvPedidos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "v_hora_viaje";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Viaje";
            gridViewTextBoxColumn1.Name = "Viaje";
            gridViewTextBoxColumn1.Width = 101;
            gridViewTextBoxColumn2.FieldName = "v_domicilio";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Domicilio";
            gridViewTextBoxColumn2.Name = "Domicilio";
            gridViewTextBoxColumn2.Width = 101;
            gridViewTextBoxColumn3.FieldName = "observacion";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Observacion";
            gridViewTextBoxColumn3.Name = "observacion";
            gridViewTextBoxColumn3.Width = 101;
            gridViewTextBoxColumn4.FieldName = "estado";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Estado";
            gridViewTextBoxColumn4.Name = "estado";
            gridViewTextBoxColumn4.Width = 100;
            this.DgvPedidos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.DgvPedidos.Name = "DgvPedidos";
            this.DgvPedidos.Padding = new System.Windows.Forms.Padding(1);
            // 
            // 
            // 
            this.DgvPedidos.RootElement.Padding = new System.Windows.Forms.Padding(1);
            this.DgvPedidos.Size = new System.Drawing.Size(424, 345);
            this.DgvPedidos.TabIndex = 0;
            this.DgvPedidos.Text = "radGridView1";
            this.DgvPedidos.ThemeName = "TelerikMetro";
            // 
            // BtnCargarGrilla
            // 
            this.BtnCargarGrilla.Location = new System.Drawing.Point(148, 389);
            this.BtnCargarGrilla.Name = "BtnCargarGrilla";
            this.BtnCargarGrilla.Size = new System.Drawing.Size(130, 24);
            this.BtnCargarGrilla.TabIndex = 1;
            this.BtnCargarGrilla.Text = "Cargar Grilla";
            this.BtnCargarGrilla.ThemeName = "TelerikMetro";
            this.BtnCargarGrilla.Click += new System.EventHandler(this.BtnCargarGrilla_Click);
            // 
            // BtnGenerarPedidos
            // 
            this.BtnGenerarPedidos.Location = new System.Drawing.Point(288, 389);
            this.BtnGenerarPedidos.Name = "BtnGenerarPedidos";
            this.BtnGenerarPedidos.Size = new System.Drawing.Size(130, 24);
            this.BtnGenerarPedidos.TabIndex = 2;
            this.BtnGenerarPedidos.Text = "Generar Pedidos";
            this.BtnGenerarPedidos.ThemeName = "TelerikMetro";
            this.BtnGenerarPedidos.Click += new System.EventHandler(this.BtnGenerarPedidos_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(12, 389);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(130, 24);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.ThemeName = "TelerikMetro";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TimerEnvio
            // 
            this.TimerEnvio.Interval = 1000;
            this.TimerEnvio.Tick += new System.EventHandler(this.TimerEnvio_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pedidos IVR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pedidos CQV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(869, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pedidos Apipe";
            // 
            // DgvCQV
            // 
            this.DgvCQV.AllowDrop = true;
            this.DgvCQV.Location = new System.Drawing.Point(442, 38);
            // 
            // DgvCQV
            // 
            this.DgvCQV.MasterTemplate.AllowAddNewRow = false;
            this.DgvCQV.MasterTemplate.AllowColumnReorder = false;
            this.DgvCQV.MasterTemplate.AllowDeleteRow = false;
            this.DgvCQV.MasterTemplate.AllowDragToGroup = false;
            this.DgvCQV.MasterTemplate.AllowEditRow = false;
            this.DgvCQV.MasterTemplate.AllowRowResize = false;
            this.DgvCQV.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn5.FieldName = "v_hora_viaje";
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "Viaje";
            gridViewTextBoxColumn5.Name = "Viaje";
            gridViewTextBoxColumn5.Width = 91;
            gridViewTextBoxColumn6.FieldName = "v_domicilio";
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "Domicilio";
            gridViewTextBoxColumn6.Name = "Domicilio";
            gridViewTextBoxColumn6.Width = 91;
            gridViewTextBoxColumn7.FieldName = "observacion";
            gridViewTextBoxColumn7.FormatString = "";
            gridViewTextBoxColumn7.HeaderText = "Observacion";
            gridViewTextBoxColumn7.Name = "observacion";
            gridViewTextBoxColumn7.Width = 91;
            gridViewTextBoxColumn8.FieldName = "Estado";
            gridViewTextBoxColumn8.FormatString = "";
            gridViewTextBoxColumn8.HeaderText = "Estado";
            gridViewTextBoxColumn8.Name = "estado";
            gridViewTextBoxColumn8.Width = 88;
            gridViewTextBoxColumn9.FieldName = "IdCQV";
            gridViewTextBoxColumn9.HeaderText = "IdCQV";
            gridViewTextBoxColumn9.Name = "IdCQV";
            gridViewTextBoxColumn9.Width = 45;
            this.DgvCQV.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9});
            this.DgvCQV.Name = "DgvCQV";
            this.DgvCQV.Size = new System.Drawing.Size(424, 345);
            this.DgvCQV.TabIndex = 1;
            this.DgvCQV.Text = "radGridView1";
            this.DgvCQV.ThemeName = "TelerikMetro";
            // 
            // DgvApipe
            // 
            this.DgvApipe.AllowDrop = true;
            this.DgvApipe.Location = new System.Drawing.Point(872, 38);
            // 
            // DgvApipe
            // 
            this.DgvApipe.MasterTemplate.AllowAddNewRow = false;
            this.DgvApipe.MasterTemplate.AllowColumnReorder = false;
            this.DgvApipe.MasterTemplate.AllowDeleteRow = false;
            this.DgvApipe.MasterTemplate.AllowDragToGroup = false;
            this.DgvApipe.MasterTemplate.AllowEditRow = false;
            this.DgvApipe.MasterTemplate.AllowRowResize = false;
            this.DgvApipe.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn10.FieldName = "v_hora_viaje";
            gridViewTextBoxColumn10.FormatString = "";
            gridViewTextBoxColumn10.HeaderText = "Viaje";
            gridViewTextBoxColumn10.Name = "Viaje";
            gridViewTextBoxColumn10.Width = 102;
            gridViewTextBoxColumn11.FieldName = "v_domicilio";
            gridViewTextBoxColumn11.FormatString = "";
            gridViewTextBoxColumn11.HeaderText = "Domicilio";
            gridViewTextBoxColumn11.Name = "Domicilio";
            gridViewTextBoxColumn11.Width = 102;
            gridViewTextBoxColumn12.FieldName = "observacion";
            gridViewTextBoxColumn12.FormatString = "";
            gridViewTextBoxColumn12.HeaderText = "Observacion";
            gridViewTextBoxColumn12.Name = "observacion";
            gridViewTextBoxColumn12.Width = 102;
            gridViewTextBoxColumn13.FieldName = "estado";
            gridViewTextBoxColumn13.FormatString = "";
            gridViewTextBoxColumn13.HeaderText = "Estado";
            gridViewTextBoxColumn13.Name = "estado";
            gridViewTextBoxColumn13.Width = 99;
            this.DgvApipe.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13});
            this.DgvApipe.Name = "DgvApipe";
            this.DgvApipe.Size = new System.Drawing.Size(424, 345);
            this.DgvApipe.TabIndex = 1;
            this.DgvApipe.Text = "radGridView1";
            this.DgvApipe.ThemeName = "TelerikMetro";
            // 
            // timerConsultaEstados
            // 
            this.timerConsultaEstados.Interval = 60000;
            this.timerConsultaEstados.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblIVR
            // 
            this.LblIVR.AutoSize = true;
            this.LblIVR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIVR.Location = new System.Drawing.Point(118, 9);
            this.LblIVR.Name = "LblIVR";
            this.LblIVR.Size = new System.Drawing.Size(51, 18);
            this.LblIVR.TabIndex = 8;
            this.LblIVR.Text = "#PED";
            // 
            // LblCQV
            // 
            this.LblCQV.AutoSize = true;
            this.LblCQV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCQV.Location = new System.Drawing.Point(554, 9);
            this.LblCQV.Name = "LblCQV";
            this.LblCQV.Size = new System.Drawing.Size(51, 18);
            this.LblCQV.TabIndex = 9;
            this.LblCQV.Text = "#PED";
            // 
            // LblApipe
            // 
            this.LblApipe.AutoSize = true;
            this.LblApipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApipe.Location = new System.Drawing.Point(990, 9);
            this.LblApipe.Name = "LblApipe";
            this.LblApipe.Size = new System.Drawing.Size(51, 18);
            this.LblApipe.TabIndex = 10;
            this.LblApipe.Text = "#PED";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(424, 389);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(130, 24);
            this.BtnActualizar.TabIndex = 3;
            this.BtnActualizar.Text = "Actualizar Info";
            this.BtnActualizar.ThemeName = "TelerikMetro";
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // btnContador
            // 
            this.btnContador.Location = new System.Drawing.Point(587, 389);
            this.btnContador.Name = "btnContador";
            this.btnContador.Size = new System.Drawing.Size(130, 24);
            this.btnContador.TabIndex = 11;
            this.btnContador.Text = "Probar Contador";
            this.btnContador.ThemeName = "TelerikMetro";
            this.btnContador.Click += new System.EventHandler(this.btnContador_Click);
            // 
            // FrmDespachoAutomatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 425);
            this.Controls.Add(this.btnContador);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.LblApipe);
            this.Controls.Add(this.LblCQV);
            this.Controls.Add(this.LblIVR);
            this.Controls.Add(this.DgvApipe);
            this.Controls.Add(this.DgvCQV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnGenerarPedidos);
            this.Controls.Add(this.BtnCargarGrilla);
            this.Controls.Add(this.DgvPedidos);
            this.Name = "FrmDespachoAutomatico";
            this.Text = "Despacho Automatico";
            this.Load += new System.EventHandler(this.FrmDespachoAutomatico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCargarGrilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGenerarPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCQV.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCQV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvApipe.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvApipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnContador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView DgvPedidos;
        private Telerik.WinControls.UI.RadButton BtnCargarGrilla;
        private Telerik.WinControls.UI.RadButton BtnGenerarPedidos;
        private Telerik.WinControls.UI.RadButton BtnLogin;
        private System.Windows.Forms.Timer TimerEnvio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadGridView DgvCQV;
        private Telerik.WinControls.UI.RadGridView DgvApipe;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private System.Windows.Forms.Timer timerConsultaEstados;
        private System.Windows.Forms.Label LblIVR;
        private System.Windows.Forms.Label LblCQV;
        private System.Windows.Forms.Label LblApipe;
        private Telerik.WinControls.UI.RadButton BtnActualizar;
        private Telerik.WinControls.UI.RadButton btnContador;
    }
}

