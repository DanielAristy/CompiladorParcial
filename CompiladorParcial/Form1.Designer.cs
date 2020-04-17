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
            this.bntLimpiar = new System.Windows.Forms.Button();
            this.TablaSimbolos = new System.Windows.Forms.Label();
            this.tablaSimbolo = new System.Windows.Forms.DataGridView();
            this.categoria_simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lexema_simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linea_simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicial_simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.final_simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaDummy = new System.Windows.Forms.Label();
            this.tablaDummys = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaError = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCompilar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSimbolo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDummys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonArchivo
            // 
            this.radioButtonArchivo.AutoSize = true;
            this.radioButtonArchivo.Location = new System.Drawing.Point(34, 29);
            this.radioButtonArchivo.Name = "radioButtonArchivo";
            this.radioButtonArchivo.Size = new System.Drawing.Size(106, 17);
            this.radioButtonArchivo.TabIndex = 0;
            this.radioButtonArchivo.Text = "Archivo de Texto";
            this.radioButtonArchivo.UseVisualStyleBackColor = true;
            this.radioButtonArchivo.CheckedChanged += new System.EventHandler(this.radioButtonArchivo_CheckedChanged);
            // 
            // radioButtonConsola
            // 
            this.radioButtonConsola.AutoSize = true;
            this.radioButtonConsola.Location = new System.Drawing.Point(158, 29);
            this.radioButtonConsola.Name = "radioButtonConsola";
            this.radioButtonConsola.Size = new System.Drawing.Size(82, 17);
            this.radioButtonConsola.TabIndex = 1;
            this.radioButtonConsola.Text = "Por Consola";
            this.radioButtonConsola.UseVisualStyleBackColor = true;
            this.radioButtonConsola.CheckedChanged += new System.EventHandler(this.radioButtonConsola_CheckedChanged);
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
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // bntLimpiar
            // 
            this.bntLimpiar.Location = new System.Drawing.Point(290, 429);
            this.bntLimpiar.Name = "bntLimpiar";
            this.bntLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpiar.TabIndex = 7;
            this.bntLimpiar.Text = "Limpiar";
            this.bntLimpiar.UseVisualStyleBackColor = true;
            this.bntLimpiar.Click += new System.EventHandler(this.bntLimpiar_Click);
            // 
            // TablaSimbolos
            // 
            this.TablaSimbolos.AutoSize = true;
            this.TablaSimbolos.Location = new System.Drawing.Point(663, 71);
            this.TablaSimbolos.Name = "TablaSimbolos";
            this.TablaSimbolos.Size = new System.Drawing.Size(99, 13);
            this.TablaSimbolos.TabIndex = 8;
            this.TablaSimbolos.Text = "TABLA SIMBOLOS";
            // 
            // tablaSimbolo
            // 
            this.tablaSimbolo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaSimbolo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoria_simbolo,
            this.lexema_simbolo,
            this.linea_simbolo,
            this.inicial_simbolo,
            this.final_simbolo});
            this.tablaSimbolo.Location = new System.Drawing.Point(434, 110);
            this.tablaSimbolo.Name = "tablaSimbolo";
            this.tablaSimbolo.Size = new System.Drawing.Size(538, 150);
            this.tablaSimbolo.TabIndex = 9;
            // 
            // categoria_simbolo
            // 
            this.categoria_simbolo.HeaderText = "Categoria";
            this.categoria_simbolo.Name = "categoria_simbolo";
            // 
            // lexema_simbolo
            // 
            this.lexema_simbolo.HeaderText = "Lexema";
            this.lexema_simbolo.Name = "lexema_simbolo";
            // 
            // linea_simbolo
            // 
            this.linea_simbolo.HeaderText = "Numero Linea";
            this.linea_simbolo.Name = "linea_simbolo";
            // 
            // inicial_simbolo
            // 
            this.inicial_simbolo.HeaderText = "Posicion Inicial";
            this.inicial_simbolo.Name = "inicial_simbolo";
            // 
            // final_simbolo
            // 
            this.final_simbolo.HeaderText = "Posicion Final";
            this.final_simbolo.Name = "final_simbolo";
            // 
            // tablaDummy
            // 
            this.tablaDummy.AutoSize = true;
            this.tablaDummy.Location = new System.Drawing.Point(663, 274);
            this.tablaDummy.Name = "tablaDummy";
            this.tablaDummy.Size = new System.Drawing.Size(92, 13);
            this.tablaDummy.TabIndex = 10;
            this.tablaDummy.Text = "TABLA DUMMYS";
            // 
            // tablaDummys
            // 
            this.tablaDummys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDummys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tablaDummys.Location = new System.Drawing.Point(434, 301);
            this.tablaDummys.Name = "tablaDummys";
            this.tablaDummys.Size = new System.Drawing.Size(538, 150);
            this.tablaDummys.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Lexema";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Numero Linea";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Posicion Inicial";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Posicion Final";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tablaError
            // 
            this.tablaError.AutoSize = true;
            this.tablaError.Location = new System.Drawing.Point(663, 478);
            this.tablaError.Name = "tablaError";
            this.tablaError.Size = new System.Drawing.Size(97, 13);
            this.tablaError.TabIndex = 12;
            this.tablaError.Text = "TABLA ERRORES";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridView1.Location = new System.Drawing.Point(434, 518);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Lexema";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Numero Linea";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Posicion Inicial";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Posicion Final";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // btnCompilar
            // 
            this.btnCompilar.Location = new System.Drawing.Point(34, 428);
            this.btnCompilar.Name = "btnCompilar";
            this.btnCompilar.Size = new System.Drawing.Size(75, 23);
            this.btnCompilar.TabIndex = 14;
            this.btnCompilar.Text = "Compilar";
            this.btnCompilar.UseVisualStyleBackColor = true;
            this.btnCompilar.Click += new System.EventHandler(this.btnCompilar_Click);
            // 
            // Compilador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 725);
            this.Controls.Add(this.btnCompilar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tablaError);
            this.Controls.Add(this.tablaDummys);
            this.Controls.Add(this.tablaDummy);
            this.Controls.Add(this.tablaSimbolo);
            this.Controls.Add(this.TablaSimbolos);
            this.Controls.Add(this.bntLimpiar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.consola);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.radioButtonConsola);
            this.Controls.Add(this.radioButtonArchivo);
            this.Name = "Compilador";
            this.Text = "Compilador";
            this.Load += new System.EventHandler(this.Compilador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaSimbolo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDummys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button bntLimpiar;
        private System.Windows.Forms.Label TablaSimbolos;
        private System.Windows.Forms.DataGridView tablaSimbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria_simbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn lexema_simbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn linea_simbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicial_simbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn final_simbolo;
        private System.Windows.Forms.Label tablaDummy;
        private System.Windows.Forms.DataGridView tablaDummys;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label tablaError;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button btnCompilar;
    }
}

