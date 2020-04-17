namespace CompiladorParcial
{
    partial class Compilador
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
            this.radioButtonArchivo = new System.Windows.Forms.RadioButton();
            this.radioButtonConsola = new System.Windows.Forms.RadioButton();
            this.URL = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.consola = new System.Windows.Forms.RichTextBox();
            this.salida = new System.Windows.Forms.RichTextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonArchivo
            // 
            this.radioButtonArchivo.AutoSize = true;
            this.radioButtonArchivo.Location = new System.Drawing.Point(34, 29);
            this.radioButtonArchivo.Name = "radioButtonArchivo";
            this.radioButtonArchivo.Size = new System.Drawing.Size(106, 17);
            this.radioButtonArchivo.TabIndex = 0;
            this.radioButtonArchivo.TabStop = true;
            this.radioButtonArchivo.Text = "Archivo de Texto";
            this.radioButtonArchivo.UseVisualStyleBackColor = true;
            // 
            // radioButtonConsola
            // 
            this.radioButtonConsola.AutoSize = true;
            this.radioButtonConsola.Location = new System.Drawing.Point(158, 29);
            this.radioButtonConsola.Name = "radioButtonConsola";
            this.radioButtonConsola.Size = new System.Drawing.Size(82, 17);
            this.radioButtonConsola.TabIndex = 1;
            this.radioButtonConsola.TabStop = true;
            this.radioButtonConsola.Text = "Por Consola";
            this.radioButtonConsola.UseVisualStyleBackColor = true;
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(34, 68);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(227, 20);
            this.URL.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(290, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // consola
            // 
            this.consola.Location = new System.Drawing.Point(34, 110);
            this.consola.Name = "consola";
            this.consola.Size = new System.Drawing.Size(331, 117);
            this.consola.TabIndex = 4;
            this.consola.Text = "";
            // 
            // salida
            // 
            this.salida.Location = new System.Drawing.Point(34, 271);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(331, 128);
            this.salida.TabIndex = 5;
            this.salida.Text = "";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(45, 234);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // Compilador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 729);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.consola);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.radioButtonConsola);
            this.Controls.Add(this.radioButtonArchivo);
            this.Name = "Compilador";
            this.Text = "Compilador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonArchivo;
        private System.Windows.Forms.RadioButton radioButtonConsola;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RichTextBox consola;
        private System.Windows.Forms.RichTextBox salida;
        private System.Windows.Forms.Button btnCargar;
    }
}

