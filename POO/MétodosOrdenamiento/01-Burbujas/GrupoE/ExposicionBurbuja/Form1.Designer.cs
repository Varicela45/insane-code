namespace ExposicionBurbuja
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            rbtnConSeñal = new RadioButton();
            rbtnDerecha = new RadioButton();
            rbtnIzquierda = new RadioButton();
            groupBox2 = new GroupBox();
            picbxGrafica = new PictureBox();
            txtPreguntas = new TextBox();
            txtComparaciones = new TextBox();
            txtMovimientos = new TextBox();
            txtTiempo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            rbtnDescendente = new RadioButton();
            rbtnAscendente = new RadioButton();
            groupBox4 = new GroupBox();
            label5 = new Label();
            btnOrdenar = new Button();
            btnAleatorizar = new Button();
            cbxNumeros = new ComboBox();
            groupBox5 = new GroupBox();
            lbxDesordenados = new ListBox();
            groupBox6 = new GroupBox();
            lbxOrdenados = new ListBox();
            btnLimpiar = new Button();
            _cronometro = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbxGrafica).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnConSeñal);
            groupBox1.Controls.Add(rbtnDerecha);
            groupBox1.Controls.Add(rbtnIzquierda);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 307);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de Recorrido";
            // 
            // rbtnConSeñal
            // 
            rbtnConSeñal.AutoSize = true;
            rbtnConSeñal.Location = new Point(28, 181);
            rbtnConSeñal.Name = "rbtnConSeñal";
            rbtnConSeñal.Size = new Size(159, 38);
            rbtnConSeñal.TabIndex = 2;
            rbtnConSeñal.TabStop = true;
            rbtnConSeñal.Text = "Con Señal";
            rbtnConSeñal.UseVisualStyleBackColor = true;
            rbtnConSeñal.CheckedChanged += rbtnConSeñal_CheckedChanged;
            // 
            // rbtnDerecha
            // 
            rbtnDerecha.AutoSize = true;
            rbtnDerecha.Location = new Point(28, 126);
            rbtnDerecha.Name = "rbtnDerecha";
            rbtnDerecha.Size = new Size(135, 38);
            rbtnDerecha.TabIndex = 1;
            rbtnDerecha.TabStop = true;
            rbtnDerecha.Text = "Derecha";
            rbtnDerecha.UseVisualStyleBackColor = true;
            rbtnDerecha.CheckedChanged += rbtnDerecha_CheckedChanged;
            // 
            // rbtnIzquierda
            // 
            rbtnIzquierda.AutoSize = true;
            rbtnIzquierda.Location = new Point(28, 72);
            rbtnIzquierda.Name = "rbtnIzquierda";
            rbtnIzquierda.Size = new Size(146, 38);
            rbtnIzquierda.TabIndex = 0;
            rbtnIzquierda.TabStop = true;
            rbtnIzquierda.Text = "Izquierda";
            rbtnIzquierda.UseVisualStyleBackColor = true;
            rbtnIzquierda.CheckedChanged += rbtnIzquierda_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(picbxGrafica);
            groupBox2.Controls.Add(txtPreguntas);
            groupBox2.Controls.Add(txtComparaciones);
            groupBox2.Controls.Add(txtMovimientos);
            groupBox2.Controls.Add(txtTiempo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 325);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 312);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estadísticas";
            // 
            // picbxGrafica
            // 
            picbxGrafica.Location = new Point(432, 41);
            picbxGrafica.Name = "picbxGrafica";
            picbxGrafica.Size = new Size(362, 212);
            picbxGrafica.SizeMode = PictureBoxSizeMode.StretchImage;
            picbxGrafica.TabIndex = 8;
            picbxGrafica.TabStop = false;
            // 
            // txtPreguntas
            // 
            txtPreguntas.Location = new Point(164, 211);
            txtPreguntas.Name = "txtPreguntas";
            txtPreguntas.Size = new Size(262, 42);
            txtPreguntas.TabIndex = 7;
            txtPreguntas.TextAlign = HorizontalAlignment.Right;
            // 
            // txtComparaciones
            // 
            txtComparaciones.Location = new Point(231, 163);
            txtComparaciones.Name = "txtComparaciones";
            txtComparaciones.Size = new Size(195, 42);
            txtComparaciones.TabIndex = 6;
            txtComparaciones.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMovimientos
            // 
            txtMovimientos.Location = new Point(203, 115);
            txtMovimientos.Name = "txtMovimientos";
            txtMovimientos.Size = new Size(223, 42);
            txtMovimientos.TabIndex = 5;
            txtMovimientos.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(137, 65);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(289, 42);
            txtTiempo.TabIndex = 4;
            txtTiempo.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 222);
            label4.Name = "label4";
            label4.Size = new Size(139, 34);
            label4.TabIndex = 3;
            label4.Text = "Preguntas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 171);
            label3.Name = "label3";
            label3.Size = new Size(206, 34);
            label3.TabIndex = 2;
            label3.Text = "Comparaciones:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 123);
            label2.Name = "label2";
            label2.Size = new Size(178, 34);
            label2.TabIndex = 1;
            label2.Text = "Movimientos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 73);
            label1.Name = "label1";
            label1.Size = new Size(114, 34);
            label1.TabIndex = 0;
            label1.Text = "Tiempo:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbtnDescendente);
            groupBox3.Controls.Add(rbtnAscendente);
            groupBox3.Location = new Point(311, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(295, 164);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Modo";
            // 
            // rbtnDescendente
            // 
            rbtnDescendente.AutoSize = true;
            rbtnDescendente.Location = new Point(18, 95);
            rbtnDescendente.Name = "rbtnDescendente";
            rbtnDescendente.Size = new Size(172, 38);
            rbtnDescendente.TabIndex = 1;
            rbtnDescendente.TabStop = true;
            rbtnDescendente.Text = "Descendete";
            rbtnDescendente.UseVisualStyleBackColor = true;
            // 
            // rbtnAscendente
            // 
            rbtnAscendente.AutoSize = true;
            rbtnAscendente.Location = new Point(18, 51);
            rbtnAscendente.Name = "rbtnAscendente";
            rbtnAscendente.Size = new Size(173, 38);
            rbtnAscendente.TabIndex = 0;
            rbtnAscendente.TabStop = true;
            rbtnAscendente.Text = "Ascendente";
            rbtnAscendente.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(btnOrdenar);
            groupBox4.Controls.Add(btnAleatorizar);
            groupBox4.Controls.Add(cbxNumeros);
            groupBox4.Location = new Point(612, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 307);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Generar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(24, 38);
            label5.Name = "label5";
            label5.Size = new Size(123, 33);
            label5.TabIndex = 5;
            label5.Text = "Numeros:";
            // 
            // btnOrdenar
            // 
            btnOrdenar.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrdenar.Location = new Point(24, 216);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(151, 40);
            btnOrdenar.TabIndex = 3;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnAleatorizar
            // 
            btnAleatorizar.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAleatorizar.Location = new Point(24, 126);
            btnAleatorizar.Name = "btnAleatorizar";
            btnAleatorizar.Size = new Size(151, 40);
            btnAleatorizar.TabIndex = 2;
            btnAleatorizar.Text = "Aleatorizar";
            btnAleatorizar.UseVisualStyleBackColor = true;
            btnAleatorizar.Click += btnAleatorizar_Click;
            // 
            // cbxNumeros
            // 
            cbxNumeros.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNumeros.FormattingEnabled = true;
            cbxNumeros.Items.AddRange(new object[] { "10", "100", "1000", "5000" });
            cbxNumeros.Location = new Point(24, 74);
            cbxNumeros.Name = "cbxNumeros";
            cbxNumeros.Size = new Size(151, 42);
            cbxNumeros.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lbxDesordenados);
            groupBox5.Location = new Point(818, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(209, 625);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Desordenados";
            // 
            // lbxDesordenados
            // 
            lbxDesordenados.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbxDesordenados.FormattingEnabled = true;
            lbxDesordenados.ItemHeight = 31;
            lbxDesordenados.Location = new Point(15, 41);
            lbxDesordenados.Name = "lbxDesordenados";
            lbxDesordenados.Size = new Size(176, 562);
            lbxDesordenados.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lbxOrdenados);
            groupBox6.Location = new Point(1033, 12);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(209, 625);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "Ordenados";
            // 
            // lbxOrdenados
            // 
            lbxOrdenados.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbxOrdenados.FormattingEnabled = true;
            lbxOrdenados.ItemHeight = 31;
            lbxOrdenados.Location = new Point(15, 41);
            lbxOrdenados.Name = "lbxOrdenados";
            lbxOrdenados.Size = new Size(176, 562);
            lbxOrdenados.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.WhiteSmoke;
            btnLimpiar.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.ForeColor = SystemColors.ControlText;
            btnLimpiar.Location = new Point(378, 228);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(148, 45);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar todo";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // _cronometro
            // 
            _cronometro.Enabled = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 649);
            Controls.Add(btnLimpiar);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Burbuja";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbxGrafica).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtPreguntas;
        private TextBox txtComparaciones;
        private TextBox txtMovimientos;
        private TextBox txtTiempo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton rbtnConSeñal;
        private RadioButton rbtnDerecha;
        private RadioButton rbtnIzquierda;
        private PictureBox picbxGrafica;
        private GroupBox groupBox3;
        private RadioButton rbtnDescendente;
        private RadioButton rbtnAscendente;
        private GroupBox groupBox4;
        private Button btnOrdenar;
        private Button btnAleatorizar;
        private ComboBox cbxNumeros;
        private GroupBox groupBox5;
        private ListBox lbxDesordenados;
        private GroupBox groupBox6;
        private ListBox lbxOrdenados;
        private Button btnLimpiar;
        private System.Windows.Forms.Timer _cronometro;
        private Label label5;
    }
}