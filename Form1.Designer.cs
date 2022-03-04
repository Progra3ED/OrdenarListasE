namespace OrdenarListasE
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonOrdenarNumero = new System.Windows.Forms.Button();
            this.buttonOrdenarFecha = new System.Windows.Forms.Button();
            this.buttonOrdenAlfabetico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(148, 118);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 23);
            this.textBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(143, 308);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(171, 73);
            this.buttonIngresar.TabIndex = 3;
            this.buttonIngresar.Text = "ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(421, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(490, 214);
            this.dataGridView1.TabIndex = 4;
            // 
            // buttonOrdenarNumero
            // 
            this.buttonOrdenarNumero.Location = new System.Drawing.Point(358, 315);
            this.buttonOrdenarNumero.Name = "buttonOrdenarNumero";
            this.buttonOrdenarNumero.Size = new System.Drawing.Size(143, 66);
            this.buttonOrdenarNumero.TabIndex = 5;
            this.buttonOrdenarNumero.Text = "Ordenar Numerico";
            this.buttonOrdenarNumero.UseVisualStyleBackColor = true;
            this.buttonOrdenarNumero.Click += new System.EventHandler(this.buttonOrdenarNumero_Click);
            // 
            // buttonOrdenarFecha
            // 
            this.buttonOrdenarFecha.Location = new System.Drawing.Point(536, 319);
            this.buttonOrdenarFecha.Name = "buttonOrdenarFecha";
            this.buttonOrdenarFecha.Size = new System.Drawing.Size(145, 62);
            this.buttonOrdenarFecha.TabIndex = 6;
            this.buttonOrdenarFecha.Text = "Ordenar Fecha";
            this.buttonOrdenarFecha.UseVisualStyleBackColor = true;
            this.buttonOrdenarFecha.Click += new System.EventHandler(this.buttonOrdenarFecha_Click);
            // 
            // buttonOrdenAlfabetico
            // 
            this.buttonOrdenAlfabetico.Location = new System.Drawing.Point(718, 320);
            this.buttonOrdenAlfabetico.Name = "buttonOrdenAlfabetico";
            this.buttonOrdenAlfabetico.Size = new System.Drawing.Size(153, 61);
            this.buttonOrdenAlfabetico.TabIndex = 7;
            this.buttonOrdenAlfabetico.Text = "Ordenar Alfabetico";
            this.buttonOrdenAlfabetico.UseVisualStyleBackColor = true;
            this.buttonOrdenAlfabetico.Click += new System.EventHandler(this.buttonOrdenAlfabetico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 506);
            this.Controls.Add(this.buttonOrdenAlfabetico);
            this.Controls.Add(this.buttonOrdenarFecha);
            this.Controls.Add(this.buttonOrdenarNumero);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonOrdenarNumero;
        private System.Windows.Forms.Button buttonOrdenarFecha;
        private System.Windows.Forms.Button buttonOrdenAlfabetico;
    }
}
