namespace Pila_Desordenada
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNoPedimento = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtPeligrosa = new System.Windows.Forms.RadioButton();
            this.rbtPerecederas = new System.Windows.Forms.RadioButton();
            this.rbtFragil = new System.Windows.Forms.RadioButton();
            this.rbtGranel = new System.Windows.Forms.RadioButton();
            this.rbtGeneral = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesoNeto = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHorarioEntrada = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreConductor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chkInspeccion = new System.Windows.Forms.CheckBox();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnNodosRandom = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEliminarTop = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvListadePedimentos = new System.Windows.Forms.DataGridView();
            this.NoPedimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoConductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inspeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxLote = new System.Windows.Forms.ComboBox();
            this.cbxRazon = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadePedimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoPedimento
            // 
            this.txtNoPedimento.Location = new System.Drawing.Point(31, 131);
            this.txtNoPedimento.Name = "txtNoPedimento";
            this.txtNoPedimento.Size = new System.Drawing.Size(227, 31);
            this.txtNoPedimento.TabIndex = 0;
            this.txtNoPedimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoPedimento_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtPeligrosa);
            this.groupBox1.Controls.Add(this.rbtPerecederas);
            this.groupBox1.Controls.Add(this.rbtFragil);
            this.groupBox1.Controls.Add(this.rbtGranel);
            this.groupBox1.Controls.Add(this.rbtGeneral);
            this.groupBox1.Location = new System.Drawing.Point(368, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 165);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // rbtPeligrosa
            // 
            this.rbtPeligrosa.AutoSize = true;
            this.rbtPeligrosa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtPeligrosa.Location = new System.Drawing.Point(144, 77);
            this.rbtPeligrosa.Name = "rbtPeligrosa";
            this.rbtPeligrosa.Size = new System.Drawing.Size(108, 29);
            this.rbtPeligrosa.TabIndex = 96;
            this.rbtPeligrosa.TabStop = true;
            this.rbtPeligrosa.Text = "Peligrosa";
            this.rbtPeligrosa.UseVisualStyleBackColor = true;
            // 
            // rbtPerecederas
            // 
            this.rbtPerecederas.AutoSize = true;
            this.rbtPerecederas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtPerecederas.Location = new System.Drawing.Point(144, 30);
            this.rbtPerecederas.Name = "rbtPerecederas";
            this.rbtPerecederas.Size = new System.Drawing.Size(130, 29);
            this.rbtPerecederas.TabIndex = 95;
            this.rbtPerecederas.TabStop = true;
            this.rbtPerecederas.Text = "Perecederas";
            this.rbtPerecederas.UseVisualStyleBackColor = true;
            // 
            // rbtFragil
            // 
            this.rbtFragil.AutoSize = true;
            this.rbtFragil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtFragil.Location = new System.Drawing.Point(19, 122);
            this.rbtFragil.Name = "rbtFragil";
            this.rbtFragil.Size = new System.Drawing.Size(80, 29);
            this.rbtFragil.TabIndex = 93;
            this.rbtFragil.TabStop = true;
            this.rbtFragil.Text = "Fragil";
            this.rbtFragil.UseVisualStyleBackColor = true;
            // 
            // rbtGranel
            // 
            this.rbtGranel.AutoSize = true;
            this.rbtGranel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtGranel.Location = new System.Drawing.Point(19, 77);
            this.rbtGranel.Name = "rbtGranel";
            this.rbtGranel.Size = new System.Drawing.Size(104, 29);
            this.rbtGranel.TabIndex = 92;
            this.rbtGranel.TabStop = true;
            this.rbtGranel.Text = "A Granel";
            this.rbtGranel.UseVisualStyleBackColor = true;
            // 
            // rbtGeneral
            // 
            this.rbtGeneral.AutoSize = true;
            this.rbtGeneral.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtGeneral.Location = new System.Drawing.Point(19, 29);
            this.rbtGeneral.Name = "rbtGeneral";
            this.rbtGeneral.Size = new System.Drawing.Size(96, 29);
            this.rbtGeneral.TabIndex = 91;
            this.rbtGeneral.TabStop = true;
            this.rbtGeneral.Text = "General";
            this.rbtGeneral.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(31, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero de Pedimento:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("NSimSun", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(31, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(889, 36);
            this.label16.TabIndex = 45;
            this.label16.Text = "TECOCOM - Exportaciones hacia todo el mundo!!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(31, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 46;
            this.label2.Text = "Peso Neto:";
            // 
            // txtPesoNeto
            // 
            this.txtPesoNeto.Location = new System.Drawing.Point(31, 200);
            this.txtPesoNeto.Name = "txtPesoNeto";
            this.txtPesoNeto.Size = new System.Drawing.Size(227, 31);
            this.txtPesoNeto.TabIndex = 1;
            this.txtPesoNeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesoNeto_KeyPress);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(31, 269);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(227, 31);
            this.txtCosto.TabIndex = 2;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(31, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Costo:";
            // 
            // dtpHorarioEntrada
            // 
            this.dtpHorarioEntrada.Location = new System.Drawing.Point(31, 343);
            this.dtpHorarioEntrada.Name = "dtpHorarioEntrada";
            this.dtpHorarioEntrada.Size = new System.Drawing.Size(300, 31);
            this.dtpHorarioEntrada.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(31, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "Fecha de entrada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(31, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 52;
            this.label5.Text = "Lote:";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(368, 200);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(227, 31);
            this.txtRFC.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(368, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 55;
            this.label6.Text = "RFC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(368, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 21);
            this.label7.TabIndex = 54;
            this.label7.Text = "Nombre del Conductor:";
            // 
            // txtNombreConductor
            // 
            this.txtNombreConductor.Location = new System.Drawing.Point(368, 131);
            this.txtNombreConductor.Name = "txtNombreConductor";
            this.txtNombreConductor.Size = new System.Drawing.Size(227, 31);
            this.txtNombreConductor.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(368, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 21);
            this.label8.TabIndex = 57;
            this.label8.Text = "Tipo de carga:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(31, 464);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 21);
            this.label9.TabIndex = 59;
            this.label9.Text = "Razon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(368, 488);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 21);
            this.label10.TabIndex = 60;
            this.label10.Text = "¿Paso por inspeccion?";
            // 
            // chkInspeccion
            // 
            this.chkInspeccion.AutoSize = true;
            this.chkInspeccion.Location = new System.Drawing.Point(598, 488);
            this.chkInspeccion.Name = "chkInspeccion";
            this.chkInspeccion.Size = new System.Drawing.Size(22, 21);
            this.chkInspeccion.TabIndex = 61;
            this.chkInspeccion.UseVisualStyleBackColor = true;
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(706, 211);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(278, 239);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 62;
            this.pbxImagen.TabStop = false;
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCargarFoto.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarFoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCargarFoto.Location = new System.Drawing.Point(757, 131);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(182, 52);
            this.btnCargarFoto.TabIndex = 63;
            this.btnCargarFoto.Text = "Cargar Imagen";
            this.btnCargarFoto.UseVisualStyleBackColor = false;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(773, 478);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 21);
            this.label11.TabIndex = 64;
            this.label11.Text = "Sitio de entrega";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(1058, 349);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(350, 24);
            this.label13.TabIndex = 66;
            this.label13.Text = "Escriba aqui el numero de pedimento:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(1020, 320);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(422, 24);
            this.label12.TabIndex = 65;
            this.label12.Text = "¿Desea buscar informacion de un pedimento?";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(1084, 417);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(169, 31);
            this.txtBuscar.TabIndex = 67;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(1259, 412);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(139, 41);
            this.btnBuscar.TabIndex = 68;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(1458, 374);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 24);
            this.label15.TabIndex = 69;
            this.label15.Text = "Limpiar Casillas:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(1634, 362);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(139, 41);
            this.btnLimpiar.TabIndex = 70;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(1132, 110);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(182, 66);
            this.btnAgregar.TabIndex = 71;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnNodosRandom
            // 
            this.btnNodosRandom.BackColor = System.Drawing.Color.DarkCyan;
            this.btnNodosRandom.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNodosRandom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNodosRandom.Location = new System.Drawing.Point(1320, 110);
            this.btnNodosRandom.Name = "btnNodosRandom";
            this.btnNodosRandom.Size = new System.Drawing.Size(182, 66);
            this.btnNodosRandom.TabIndex = 72;
            this.btnNodosRandom.Text = "Generar aleatorios";
            this.btnNodosRandom.UseVisualStyleBackColor = false;
            this.btnNodosRandom.Click += new System.EventHandler(this.btnNodosRandom_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(1132, 182);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(182, 66);
            this.btnEliminar.TabIndex = 73;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEliminarTop
            // 
            this.btnEliminarTop.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEliminarTop.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarTop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarTop.Location = new System.Drawing.Point(1320, 182);
            this.btnEliminarTop.Name = "btnEliminarTop";
            this.btnEliminarTop.Size = new System.Drawing.Size(182, 66);
            this.btnEliminarTop.TabIndex = 74;
            this.btnEliminarTop.Text = "Eliminar el Top";
            this.btnEliminarTop.UseVisualStyleBackColor = false;
            this.btnEliminarTop.Click += new System.EventHandler(this.btnEliminarTop_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnVaciar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVaciar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVaciar.Location = new System.Drawing.Point(1508, 110);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(182, 66);
            this.btnVaciar.TabIndex = 75;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(1508, 182);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(182, 66);
            this.btnSalir.TabIndex = 76;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvListadePedimentos
            // 
            this.dgvListadePedimentos.AllowUserToAddRows = false;
            this.dgvListadePedimentos.AllowUserToDeleteRows = false;
            this.dgvListadePedimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadePedimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoPedimento,
            this.PesoNeto,
            this.Costo,
            this.NoConductor,
            this.RFC,
            this.Razon,
            this.TipoCarga,
            this.Lote,
            this.HorarioEntrada,
            this.Inspeccion,
            this.Imagen});
            this.dgvListadePedimentos.Location = new System.Drawing.Point(86, 541);
            this.dgvListadePedimentos.Name = "dgvListadePedimentos";
            this.dgvListadePedimentos.ReadOnly = true;
            this.dgvListadePedimentos.RowHeadersWidth = 62;
            this.dgvListadePedimentos.RowTemplate.Height = 33;
            this.dgvListadePedimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadePedimentos.Size = new System.Drawing.Size(1618, 342);
            this.dgvListadePedimentos.TabIndex = 77;
            this.dgvListadePedimentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadePedimentos_CellClick);
            // 
            // NoPedimento
            // 
            this.NoPedimento.HeaderText = "Numero de Pedimento";
            this.NoPedimento.MinimumWidth = 8;
            this.NoPedimento.Name = "NoPedimento";
            this.NoPedimento.ReadOnly = true;
            this.NoPedimento.Width = 150;
            // 
            // PesoNeto
            // 
            this.PesoNeto.HeaderText = "Peso Neto";
            this.PesoNeto.MinimumWidth = 8;
            this.PesoNeto.Name = "PesoNeto";
            this.PesoNeto.ReadOnly = true;
            this.PesoNeto.Width = 150;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 8;
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Width = 150;
            // 
            // NoConductor
            // 
            this.NoConductor.HeaderText = "Nombre del Conductor";
            this.NoConductor.MinimumWidth = 8;
            this.NoConductor.Name = "NoConductor";
            this.NoConductor.ReadOnly = true;
            this.NoConductor.Width = 200;
            // 
            // RFC
            // 
            this.RFC.HeaderText = "RFC";
            this.RFC.MinimumWidth = 8;
            this.RFC.Name = "RFC";
            this.RFC.ReadOnly = true;
            this.RFC.Width = 150;
            // 
            // Razon
            // 
            this.Razon.HeaderText = "Razon";
            this.Razon.MinimumWidth = 8;
            this.Razon.Name = "Razon";
            this.Razon.ReadOnly = true;
            this.Razon.Width = 150;
            // 
            // TipoCarga
            // 
            this.TipoCarga.HeaderText = "Tipo de Carga";
            this.TipoCarga.MinimumWidth = 8;
            this.TipoCarga.Name = "TipoCarga";
            this.TipoCarga.ReadOnly = true;
            this.TipoCarga.Width = 150;
            // 
            // Lote
            // 
            this.Lote.HeaderText = "Lote";
            this.Lote.MinimumWidth = 8;
            this.Lote.Name = "Lote";
            this.Lote.ReadOnly = true;
            this.Lote.Width = 80;
            // 
            // HorarioEntrada
            // 
            this.HorarioEntrada.HeaderText = "Fecha de Entrada";
            this.HorarioEntrada.MinimumWidth = 8;
            this.HorarioEntrada.Name = "HorarioEntrada";
            this.HorarioEntrada.ReadOnly = true;
            this.HorarioEntrada.Width = 240;
            // 
            // Inspeccion
            // 
            this.Inspeccion.HeaderText = "Inspeccion";
            this.Inspeccion.MinimumWidth = 8;
            this.Inspeccion.Name = "Inspeccion";
            this.Inspeccion.ReadOnly = true;
            this.Inspeccion.Width = 130;
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.MinimumWidth = 8;
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Visible = false;
            this.Imagen.Width = 150;
            // 
            // cbxLote
            // 
            this.cbxLote.FormattingEnabled = true;
            this.cbxLote.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "M",
            "N",
            "O",
            "L",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cbxLote.Location = new System.Drawing.Point(31, 417);
            this.cbxLote.Name = "cbxLote";
            this.cbxLote.Size = new System.Drawing.Size(128, 33);
            this.cbxLote.TabIndex = 4;
            // 
            // cbxRazon
            // 
            this.cbxRazon.FormattingEnabled = true;
            this.cbxRazon.Items.AddRange(new object[] {
            "Alimentaria",
            "Construccion",
            "Tecnologia"});
            this.cbxRazon.Location = new System.Drawing.Point(31, 488);
            this.cbxRazon.Name = "cbxRazon";
            this.cbxRazon.Size = new System.Drawing.Size(128, 33);
            this.cbxRazon.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1801, 909);
            this.Controls.Add(this.cbxRazon);
            this.Controls.Add(this.dgvListadePedimentos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnEliminarTop);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNodosRandom);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCargarFoto);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.chkInspeccion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombreConductor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpHorarioEntrada);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPesoNeto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxLote);
            this.Controls.Add(this.txtNoPedimento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadePedimentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNoPedimento;
        private GroupBox groupBox1;
        private RadioButton rbtPeligrosa;
        private RadioButton rbtPerecederas;
        private RadioButton rbtFragil;
        private RadioButton rbtGranel;
        private RadioButton rbtGeneral;
        private Label label1;
        private Label label16;
        private Label label2;
        private TextBox txtPesoNeto;
        private TextBox txtCosto;
        private Label label3;
        private DateTimePicker dtpHorarioEntrada;
        private Label label4;
        private Label label5;
        private TextBox txtRFC;
        private Label label6;
        private Label label7;
        private TextBox txtNombreConductor;
        private Label label8;
        private Label label9;
        private Label label10;
        private CheckBox chkInspeccion;
        private PictureBox pbxImagen;
        private Button btnCargarFoto;
        private Label label11;
        private Label label13;
        private Label label12;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Label label15;
        private Button btnLimpiar;
        private Button btnAgregar;
        private Button btnNodosRandom;
        private Button btnEliminar;
        private Button btnEliminarTop;
        private Button btnVaciar;
        private Button btnSalir;
        private DataGridView dgvListadePedimentos;
        private ComboBox cbxLote;
        private ComboBox cbxRazon;
        private DataGridViewTextBoxColumn NoPedimento;
        private DataGridViewTextBoxColumn PesoNeto;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn NoConductor;
        private DataGridViewTextBoxColumn RFC;
        private DataGridViewTextBoxColumn Razon;
        private DataGridViewTextBoxColumn TipoCarga;
        private DataGridViewTextBoxColumn Lote;
        private DataGridViewTextBoxColumn HorarioEntrada;
        private DataGridViewTextBoxColumn Inspeccion;
        private DataGridViewTextBoxColumn Imagen;
    }
}