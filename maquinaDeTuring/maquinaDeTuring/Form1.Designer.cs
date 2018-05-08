namespace maquinaDeTuring
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAvanzarAutomatico = new System.Windows.Forms.Button();
            this.btnAvanzarPasoAPaso = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Palindromos (a, b, c)",
            "Copiar Patrones (a, b, c)",
            "Multiplicaciones Codigo Unario",
            "Suma Codigo Unario",
            "Resta Codigo Unario"});
            this.comboBox1.Location = new System.Drawing.Point(18, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introducir Cadena";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccionar Maquina de Turing";
            // 
            // btnAvanzarAutomatico
            // 
            this.btnAvanzarAutomatico.Location = new System.Drawing.Point(21, 132);
            this.btnAvanzarAutomatico.Name = "btnAvanzarAutomatico";
            this.btnAvanzarAutomatico.Size = new System.Drawing.Size(206, 48);
            this.btnAvanzarAutomatico.TabIndex = 4;
            this.btnAvanzarAutomatico.Text = "Avanzar Automatico";
            this.btnAvanzarAutomatico.UseVisualStyleBackColor = true;
            this.btnAvanzarAutomatico.Click += new System.EventHandler(this.btnAvanzarAutomatico_Click);
            // 
            // btnAvanzarPasoAPaso
            // 
            this.btnAvanzarPasoAPaso.Location = new System.Drawing.Point(21, 197);
            this.btnAvanzarPasoAPaso.Name = "btnAvanzarPasoAPaso";
            this.btnAvanzarPasoAPaso.Size = new System.Drawing.Size(206, 48);
            this.btnAvanzarPasoAPaso.TabIndex = 5;
            this.btnAvanzarPasoAPaso.Text = "Avanzar Paso a Paso";
            this.btnAvanzarPasoAPaso.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Maquina de Turing";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(257, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(599, 73);
            this.dataGridView1.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 413);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAvanzarPasoAPaso);
            this.Controls.Add(this.btnAvanzarAutomatico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAvanzarAutomatico;
        private System.Windows.Forms.Button btnAvanzarPasoAPaso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
    }
}

