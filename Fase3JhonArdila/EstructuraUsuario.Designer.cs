namespace Fase3JhonArdila
{
    partial class frmEstructuraUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cbxTipoEstructura = new System.Windows.Forms.ComboBox();
            this.txtReporteDatos = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtFechaAcceso = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValorCopago = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbLaboratorio = new System.Windows.Forms.RadioButton();
            this.rbMedicinaGeneral = new System.Windows.Forms.RadioButton();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.cbxEstratoSocial = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroIdentidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTipoIdentidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabTipoEstructuras = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEliminarPila = new System.Windows.Forms.Button();
            this.btnReportePila = new System.Windows.Forms.Button();
            this.dgPila = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEliminarCola = new System.Windows.Forms.Button();
            this.btnReporteCola = new System.Windows.Forms.Button();
            this.dgCola = new System.Windows.Forms.DataGridView();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.btnReporteLista = new System.Windows.Forms.Button();
            this.btnEliminarLista = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabTipoEstructuras.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPila)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE REGISTRO DE USUARIOS EN CENTRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "EPS Salvando Vidas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.cbxTipoIdentidad);
            this.groupBox1.Controls.Add(this.cbxTipoEstructura);
            this.groupBox1.Controls.Add(this.txtReporteDatos);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtFechaAcceso);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtValorCopago);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.txtNombreUsuario);
            this.groupBox1.Controls.Add(this.cbxEstratoSocial);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNumeroIdentidad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(665, 317);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Usuario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(422, 290);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 14);
            this.label12.TabIndex = 22;
            this.label12.Text = "Los campos marcados con (*) son obligatorios.";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(570, 246);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(69, 30);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(467, 246);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(69, 30);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrar.Location = new System.Drawing.Point(360, 246);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(69, 30);
            this.btnRegistrar.TabIndex = 19;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cbxTipoEstructura
            // 
            this.cbxTipoEstructura.BackColor = System.Drawing.SystemColors.Info;
            this.cbxTipoEstructura.FormattingEnabled = true;
            this.cbxTipoEstructura.Location = new System.Drawing.Point(147, 202);
            this.cbxTipoEstructura.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxTipoEstructura.Name = "cbxTipoEstructura";
            this.cbxTipoEstructura.Size = new System.Drawing.Size(141, 22);
            this.cbxTipoEstructura.TabIndex = 18;
            // 
            // txtReporteDatos
            // 
            this.txtReporteDatos.BackColor = System.Drawing.SystemColors.Info;
            this.txtReporteDatos.Enabled = false;
            this.txtReporteDatos.Location = new System.Drawing.Point(147, 245);
            this.txtReporteDatos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtReporteDatos.Name = "txtReporteDatos";
            this.txtReporteDatos.Size = new System.Drawing.Size(141, 22);
            this.txtReporteDatos.TabIndex = 17;
            this.txtReporteDatos.TextChanged += new System.EventHandler(this.txtReporteDatos_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 248);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 14);
            this.label11.TabIndex = 16;
            this.label11.Text = "Reporte de datos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 205);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 14);
            this.label10.TabIndex = 15;
            this.label10.Text = "*Tipo de estructura:";
            // 
            // dtFechaAcceso
            // 
            this.dtFechaAcceso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaAcceso.Location = new System.Drawing.Point(498, 188);
            this.dtFechaAcceso.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtFechaAcceso.Name = "dtFechaAcceso";
            this.dtFechaAcceso.Size = new System.Drawing.Size(81, 22);
            this.dtFechaAcceso.TabIndex = 14;
            this.dtFechaAcceso.Value = new System.DateTime(2024, 10, 17, 23, 44, 3, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 188);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 14);
            this.label9.TabIndex = 13;
            this.label9.Text = "*Fecha de acceso:";
            // 
            // txtValorCopago
            // 
            this.txtValorCopago.BackColor = System.Drawing.SystemColors.Info;
            this.txtValorCopago.Enabled = false;
            this.txtValorCopago.Location = new System.Drawing.Point(147, 159);
            this.txtValorCopago.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtValorCopago.Name = "txtValorCopago";
            this.txtValorCopago.Size = new System.Drawing.Size(141, 22);
            this.txtValorCopago.TabIndex = 12;
            this.txtValorCopago.TextChanged += new System.EventHandler(this.txtValorCopago_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "Valor del copago:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbLaboratorio);
            this.groupBox2.Controls.Add(this.rbMedicinaGeneral);
            this.groupBox2.Location = new System.Drawing.Point(359, 100);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(280, 76);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "*Tipo de atención:";
            // 
            // rbLaboratorio
            // 
            this.rbLaboratorio.AutoSize = true;
            this.rbLaboratorio.Location = new System.Drawing.Point(139, 32);
            this.rbLaboratorio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbLaboratorio.Name = "rbLaboratorio";
            this.rbLaboratorio.Size = new System.Drawing.Size(135, 18);
            this.rbLaboratorio.TabIndex = 1;
            this.rbLaboratorio.TabStop = true;
            this.rbLaboratorio.Text = "Examen de laboratorio";
            this.rbLaboratorio.UseVisualStyleBackColor = true;
            // 
            // rbMedicinaGeneral
            // 
            this.rbMedicinaGeneral.AutoSize = true;
            this.rbMedicinaGeneral.Location = new System.Drawing.Point(16, 32);
            this.rbMedicinaGeneral.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbMedicinaGeneral.Name = "rbMedicinaGeneral";
            this.rbMedicinaGeneral.Size = new System.Drawing.Size(111, 18);
            this.rbMedicinaGeneral.TabIndex = 0;
            this.rbMedicinaGeneral.TabStop = true;
            this.rbMedicinaGeneral.Text = "Medicina general ";
            this.rbMedicinaGeneral.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.SystemColors.Info;
            this.txtEdad.Location = new System.Drawing.Point(498, 64);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(141, 22);
            this.txtEdad.TabIndex = 9;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombreUsuario.Location = new System.Drawing.Point(147, 61);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(141, 22);
            this.txtNombreUsuario.TabIndex = 8;
            this.txtNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreUsuario_KeyPress);
            // 
            // cbxEstratoSocial
            // 
            this.cbxEstratoSocial.BackColor = System.Drawing.SystemColors.Info;
            this.cbxEstratoSocial.FormattingEnabled = true;
            this.cbxEstratoSocial.Location = new System.Drawing.Point(147, 107);
            this.cbxEstratoSocial.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxEstratoSocial.Name = "cbxEstratoSocial";
            this.cbxEstratoSocial.Size = new System.Drawing.Size(141, 22);
            this.cbxEstratoSocial.Sorted = true;
            this.cbxEstratoSocial.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "*Estrato socioeconómico:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "*Edad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "*Nombre completo:";
            // 
            // txtNumeroIdentidad
            // 
            this.txtNumeroIdentidad.BackColor = System.Drawing.SystemColors.Info;
            this.txtNumeroIdentidad.Location = new System.Drawing.Point(498, 26);
            this.txtNumeroIdentidad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNumeroIdentidad.Name = "txtNumeroIdentidad";
            this.txtNumeroIdentidad.Size = new System.Drawing.Size(141, 22);
            this.txtNumeroIdentidad.TabIndex = 3;
            this.txtNumeroIdentidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroIdentidad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "*Número de identidad:";
            // 
            // cbxTipoIdentidad
            // 
            this.cbxTipoIdentidad.BackColor = System.Drawing.SystemColors.Info;
            this.cbxTipoIdentidad.FormattingEnabled = true;
            this.cbxTipoIdentidad.Location = new System.Drawing.Point(147, 23);
            this.cbxTipoIdentidad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxTipoIdentidad.Name = "cbxTipoIdentidad";
            this.cbxTipoIdentidad.Size = new System.Drawing.Size(141, 22);
            this.cbxTipoIdentidad.Sorted = true;
            this.cbxTipoIdentidad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "*Tipo de identificación:";
            // 
            // tabTipoEstructuras
            // 
            this.tabTipoEstructuras.Controls.Add(this.tabPage1);
            this.tabTipoEstructuras.Controls.Add(this.tabPage2);
            this.tabTipoEstructuras.Controls.Add(this.tabPage3);
            this.tabTipoEstructuras.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTipoEstructuras.Location = new System.Drawing.Point(11, 404);
            this.tabTipoEstructuras.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabTipoEstructuras.Name = "tabTipoEstructuras";
            this.tabTipoEstructuras.SelectedIndex = 0;
            this.tabTipoEstructuras.Size = new System.Drawing.Size(715, 115);
            this.tabTipoEstructuras.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage1.Controls.Add(this.btnEliminarPila);
            this.tabPage1.Controls.Add(this.btnReportePila);
            this.tabPage1.Controls.Add(this.dgPila);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Size = new System.Drawing.Size(707, 88);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pila";
            // 
            // btnEliminarPila
            // 
            this.btnEliminarPila.BackColor = System.Drawing.SystemColors.Info;
            this.btnEliminarPila.Location = new System.Drawing.Point(620, 49);
            this.btnEliminarPila.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEliminarPila.Name = "btnEliminarPila";
            this.btnEliminarPila.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPila.TabIndex = 2;
            this.btnEliminarPila.Text = "Eliminar";
            this.btnEliminarPila.UseVisualStyleBackColor = false;
            this.btnEliminarPila.Click += new System.EventHandler(this.btnEliminarPila_Click);
            // 
            // btnReportePila
            // 
            this.btnReportePila.BackColor = System.Drawing.SystemColors.Info;
            this.btnReportePila.Location = new System.Drawing.Point(620, 19);
            this.btnReportePila.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReportePila.Name = "btnReportePila";
            this.btnReportePila.Size = new System.Drawing.Size(75, 23);
            this.btnReportePila.TabIndex = 1;
            this.btnReportePila.Text = "Reporte";
            this.btnReportePila.UseVisualStyleBackColor = false;
            this.btnReportePila.Click += new System.EventHandler(this.btnReportePila_Click);
            // 
            // dgPila
            // 
            this.dgPila.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPila.Location = new System.Drawing.Point(7, 6);
            this.dgPila.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgPila.Name = "dgPila";
            this.dgPila.Size = new System.Drawing.Size(609, 77);
            this.dgPila.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage2.Controls.Add(this.btnEliminarCola);
            this.tabPage2.Controls.Add(this.btnReporteCola);
            this.tabPage2.Controls.Add(this.dgCola);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Size = new System.Drawing.Size(707, 88);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cola";
            // 
            // btnEliminarCola
            // 
            this.btnEliminarCola.BackColor = System.Drawing.SystemColors.Info;
            this.btnEliminarCola.Location = new System.Drawing.Point(628, 48);
            this.btnEliminarCola.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEliminarCola.Name = "btnEliminarCola";
            this.btnEliminarCola.Size = new System.Drawing.Size(68, 23);
            this.btnEliminarCola.TabIndex = 5;
            this.btnEliminarCola.Text = "Eliminar";
            this.btnEliminarCola.UseVisualStyleBackColor = false;
            this.btnEliminarCola.Click += new System.EventHandler(this.btnEliminarCola_Click);
            // 
            // btnReporteCola
            // 
            this.btnReporteCola.BackColor = System.Drawing.SystemColors.Info;
            this.btnReporteCola.Location = new System.Drawing.Point(628, 18);
            this.btnReporteCola.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReporteCola.Name = "btnReporteCola";
            this.btnReporteCola.Size = new System.Drawing.Size(68, 23);
            this.btnReporteCola.TabIndex = 4;
            this.btnReporteCola.Text = "Reporte";
            this.btnReporteCola.UseVisualStyleBackColor = false;
            this.btnReporteCola.Click += new System.EventHandler(this.btnReporteCola_Click);
            // 
            // dgCola
            // 
            this.dgCola.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCola.Location = new System.Drawing.Point(9, 5);
            this.dgCola.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgCola.Name = "dgCola";
            this.dgCola.Size = new System.Drawing.Size(615, 78);
            this.dgCola.TabIndex = 3;
            // 
            // dgLista
            // 
            this.dgLista.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLista.Location = new System.Drawing.Point(7, 4);
            this.dgLista.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgLista.Name = "dgLista";
            this.dgLista.Size = new System.Drawing.Size(610, 81);
            this.dgLista.TabIndex = 3;
            // 
            // btnReporteLista
            // 
            this.btnReporteLista.BackColor = System.Drawing.SystemColors.Info;
            this.btnReporteLista.Location = new System.Drawing.Point(621, 19);
            this.btnReporteLista.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReporteLista.Name = "btnReporteLista";
            this.btnReporteLista.Size = new System.Drawing.Size(73, 23);
            this.btnReporteLista.TabIndex = 4;
            this.btnReporteLista.Text = "Reporte";
            this.btnReporteLista.UseVisualStyleBackColor = false;
            this.btnReporteLista.Click += new System.EventHandler(this.btnReporteLista_Click);
            // 
            // btnEliminarLista
            // 
            this.btnEliminarLista.BackColor = System.Drawing.SystemColors.Info;
            this.btnEliminarLista.Location = new System.Drawing.Point(621, 49);
            this.btnEliminarLista.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEliminarLista.Name = "btnEliminarLista";
            this.btnEliminarLista.Size = new System.Drawing.Size(73, 23);
            this.btnEliminarLista.TabIndex = 5;
            this.btnEliminarLista.Text = "Eliminar";
            this.btnEliminarLista.UseVisualStyleBackColor = false;
            this.btnEliminarLista.Click += new System.EventHandler(this.btnEliminarLista_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage3.Controls.Add(this.btnEliminarLista);
            this.tabPage3.Controls.Add(this.btnReporteLista);
            this.tabPage3.Controls.Add(this.dgLista);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(707, 88);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lista";
            // 
            // frmEstructuraUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(737, 531);
            this.Controls.Add(this.tabTipoEstructuras);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmEstructuraUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Usuario";
            this.Load += new System.EventHandler(this.frmEstructuraUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabTipoEstructuras.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPila)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTipoIdentidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroIdentidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.ComboBox cbxEstratoSocial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbLaboratorio;
        private System.Windows.Forms.RadioButton rbMedicinaGeneral;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValorCopago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtFechaAcceso;
        private System.Windows.Forms.TextBox txtReporteDatos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxTipoEstructura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TabControl tabTipoEstructuras;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnEliminarPila;
        private System.Windows.Forms.Button btnReportePila;
        private System.Windows.Forms.DataGridView dgPila;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEliminarCola;
        private System.Windows.Forms.Button btnReporteCola;
        private System.Windows.Forms.DataGridView dgCola;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnEliminarLista;
        private System.Windows.Forms.Button btnReporteLista;
        private System.Windows.Forms.DataGridView dgLista;
    }
}