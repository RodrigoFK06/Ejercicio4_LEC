namespace Ejercicio4_LEC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.notaTextBox = new System.Windows.Forms.TextBox();
            this.AgregarEstudiante = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.codigoBuscarTextBox = new System.Windows.Forms.TextBox();
            this.BuscarEstudiante = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.codigoEliminarTextBox = new System.Windows.Forms.TextBox();
            this.EliminarEstudiante = new System.Windows.Forms.Button();
            this.totalAprobadosLabel = new System.Windows.Forms.Label();
            this.totalDesaprobadosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE ALUMNOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CODIGO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "NOTA";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Location = new System.Drawing.Point(141, 61);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(100, 23);
            this.codigoTextBox.TabIndex = 4;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.Location = new System.Drawing.Point(368, 61);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(130, 23);
            this.nombresTextBox.TabIndex = 5;
            // 
            // notaTextBox
            // 
            this.notaTextBox.Location = new System.Drawing.Point(592, 61);
            this.notaTextBox.Name = "notaTextBox";
            this.notaTextBox.Size = new System.Drawing.Size(100, 23);
            this.notaTextBox.TabIndex = 6;
            // 
            // AgregarEstudiante
            // 
            this.AgregarEstudiante.Location = new System.Drawing.Point(769, 51);
            this.AgregarEstudiante.Name = "AgregarEstudiante";
            this.AgregarEstudiante.Size = new System.Drawing.Size(102, 41);
            this.AgregarEstudiante.TabIndex = 7;
            this.AgregarEstudiante.Text = "Agregar";
            this.AgregarEstudiante.UseVisualStyleBackColor = true;
            this.AgregarEstudiante.Click += new System.EventHandler(this.AgregarEstudiante_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Nota});
            this.dataGridView.Location = new System.Drawing.Point(177, 135);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(444, 150);
            this.dataGridView.TabIndex = 8;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Buscar por codigo";
            // 
            // codigoBuscarTextBox
            // 
            this.codigoBuscarTextBox.Location = new System.Drawing.Point(329, 314);
            this.codigoBuscarTextBox.Name = "codigoBuscarTextBox";
            this.codigoBuscarTextBox.Size = new System.Drawing.Size(100, 23);
            this.codigoBuscarTextBox.TabIndex = 10;
            // 
            // BuscarEstudiante
            // 
            this.BuscarEstudiante.Location = new System.Drawing.Point(460, 306);
            this.BuscarEstudiante.Name = "BuscarEstudiante";
            this.BuscarEstudiante.Size = new System.Drawing.Size(105, 36);
            this.BuscarEstudiante.TabIndex = 11;
            this.BuscarEstudiante.Text = "Buscar";
            this.BuscarEstudiante.UseVisualStyleBackColor = true;
            this.BuscarEstudiante.Click += new System.EventHandler(this.BuscarEstudiante_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Eliminar por codigo";
            // 
            // codigoEliminarTextBox
            // 
            this.codigoEliminarTextBox.Location = new System.Drawing.Point(329, 355);
            this.codigoEliminarTextBox.Name = "codigoEliminarTextBox";
            this.codigoEliminarTextBox.Size = new System.Drawing.Size(100, 23);
            this.codigoEliminarTextBox.TabIndex = 13;
            // 
            // EliminarEstudiante
            // 
            this.EliminarEstudiante.Location = new System.Drawing.Point(460, 349);
            this.EliminarEstudiante.Name = "EliminarEstudiante";
            this.EliminarEstudiante.Size = new System.Drawing.Size(105, 39);
            this.EliminarEstudiante.TabIndex = 14;
            this.EliminarEstudiante.Text = "Eliminar";
            this.EliminarEstudiante.UseVisualStyleBackColor = true;
            this.EliminarEstudiante.Click += new System.EventHandler(this.EliminarEstudiante_Click);
            // 
            // totalAprobadosLabel
            // 
            this.totalAprobadosLabel.AutoSize = true;
            this.totalAprobadosLabel.Location = new System.Drawing.Point(701, 187);
            this.totalAprobadosLabel.Name = "totalAprobadosLabel";
            this.totalAprobadosLabel.Size = new System.Drawing.Size(0, 15);
            this.totalAprobadosLabel.TabIndex = 15;
            // 
            // totalDesaprobadosLabel
            // 
            this.totalDesaprobadosLabel.AutoSize = true;
            this.totalDesaprobadosLabel.Location = new System.Drawing.Point(702, 282);
            this.totalDesaprobadosLabel.Name = "totalDesaprobadosLabel";
            this.totalDesaprobadosLabel.Size = new System.Drawing.Size(0, 15);
            this.totalDesaprobadosLabel.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.totalDesaprobadosLabel);
            this.Controls.Add(this.totalAprobadosLabel);
            this.Controls.Add(this.EliminarEstudiante);
            this.Controls.Add(this.codigoEliminarTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BuscarEstudiante);
            this.Controls.Add(this.codigoBuscarTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.AgregarEstudiante);
            this.Controls.Add(this.notaTextBox);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox codigoTextBox;
        private TextBox nombresTextBox;
        private TextBox notaTextBox;
        private Button AgregarEstudiante;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Nota;
        private Label label5;
        private TextBox codigoBuscarTextBox;
        private Button BuscarEstudiante;
        private Label label6;
        private TextBox codigoEliminarTextBox;
        private Button EliminarEstudiante;
        private Label totalAprobadosLabel;
        private Label totalDesaprobadosLabel;
    }
}