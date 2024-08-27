namespace Burbuja
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            button2 = new Button();
            lblTiempo = new Label();
            txtTiempo = new TextBox();
            txtMovimientos = new TextBox();
            label2 = new Label();
            txtComparaciones = new TextBox();
            label3 = new Label();
            txtPreguntas = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(9, 40);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(417, 180);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Edad";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Telefono";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5, Column6 });
            dataGridView2.Location = new Point(434, 40);
            dataGridView2.Margin = new Padding(2, 3, 2, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(411, 180);
            dataGridView2.TabIndex = 1;
            // 
            // Column4
            // 
            Column4.HeaderText = "Nombre";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Edad";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Telefono";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 150;
            // 
            // button1
            // 
            button1.Location = new Point(18, 5);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(223, 27);
            button1.TabIndex = 2;
            button1.Text = "Generar Random";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(295, 8);
            radioButton1.Margin = new Padding(2, 3, 2, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Derecha";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(381, 8);
            radioButton2.Margin = new Padding(2, 3, 2, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(92, 24);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Izquierda";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(473, 9);
            radioButton3.Margin = new Padding(2, 3, 2, 3);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 24);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "Con senal";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(569, 5);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(89, 27);
            button2.TabIndex = 6;
            button2.Text = "Ordenar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(851, 15);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(60, 20);
            lblTiempo.TabIndex = 7;
            lblTiempo.Text = "Tiempo";
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(912, 9);
            txtTiempo.Margin = new Padding(3, 4, 3, 4);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(114, 27);
            txtTiempo.TabIndex = 8;
            // 
            // txtMovimientos
            // 
            txtMovimientos.Location = new Point(946, 48);
            txtMovimientos.Margin = new Padding(3, 4, 3, 4);
            txtMovimientos.Name = "txtMovimientos";
            txtMovimientos.Size = new Size(79, 27);
            txtMovimientos.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(851, 53);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 9;
            label2.Text = "Movimientos";
            // 
            // txtComparaciones
            // 
            txtComparaciones.Location = new Point(961, 87);
            txtComparaciones.Margin = new Padding(3, 4, 3, 4);
            txtComparaciones.Name = "txtComparaciones";
            txtComparaciones.Size = new Size(65, 27);
            txtComparaciones.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(851, 92);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 11;
            label3.Text = "Comparaciones";
            // 
            // txtPreguntas
            // 
            txtPreguntas.Location = new Point(927, 125);
            txtPreguntas.Margin = new Padding(3, 4, 3, 4);
            txtPreguntas.Name = "txtPreguntas";
            txtPreguntas.Size = new Size(99, 27);
            txtPreguntas.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(851, 131);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 13;
            label4.Text = "Preguntas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 239);
            Controls.Add(txtPreguntas);
            Controls.Add(label4);
            Controls.Add(txtComparaciones);
            Controls.Add(label3);
            Controls.Add(txtMovimientos);
            Controls.Add(label2);
            Controls.Add(txtTiempo);
            Controls.Add(lblTiempo);
            Controls.Add(button2);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label lblTiempo;
        private TextBox txtTiempo;
        private TextBox txtMovimientos;
        private Label label2;
        private TextBox txtComparaciones;
        private Label label3;
        private TextBox txtPreguntas;
        private Label label4;
    }
}