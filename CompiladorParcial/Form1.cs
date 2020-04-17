using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CompiladorParcial.Caches;
using CompiladorParcial.AnalisisLexico;
using CompiladorParcial.Transversal;

namespace CompiladorParcial
{
    public partial class Compilador : Form
    {
        string linea;
        bool verificarEntrada = false;
        public Compilador()
        {
            InitializeComponent();
        }
        private void radioButtonArchivo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonArchivo.Checked)
            {
                radioButtonConsola.Enabled = false;
                consola.Enabled = false;
            }
        }
        private void radioButtonConsola_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonConsola.Checked)
            {
                radioButtonArchivo.Enabled = false;
                URL.Enabled = false;
                btnBuscar.Enabled = false;
                consola.Enabled = true;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                URL.Text = openFile.FileName;
                linea = openFile.FileName;
            }
        }

        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            radioButtonConsola.Enabled = true;
            radioButtonArchivo.Enabled = true;
            consola.Enabled = true;
            URL.Enabled = true;
            btnBuscar.Enabled = true;
            salida.Clear();
            consola.Clear();
            URL.Clear();
            Cache.LimpiarLineas();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            
            if (radioButtonArchivo.Checked)
            {
                StreamReader stream = new StreamReader(linea);

                while ((linea = stream.ReadLine()) != null)
                {
                    Cache.AgregarLinea(linea);
                }
            }else if (radioButtonConsola.Checked)
            {
                String[] datos = consola.Text.Split('\n');

                for (int i = 0; i < datos.Length; i++)
                {
                    Cache.AgregarLinea(datos[i]);
                }
            }
            CargarTextoSalida();
        }
        private void CargarTextoSalida()
        {
            foreach (Linea linea in Cache.ObtenerLineas())
            {
                salida.SelectedText = linea.Numero + "-> " + linea.Contenido + '\n';
            }
        }
        private void Analisis()
        {
            tablaSimbolo.Rows.Clear();
            AnalizadorLexico analizador = new AnalizadorLexico();
            ComponenteLexico lexico = analizador.Analizar();

            while (!!"@EOF@".Equals(lexico.Lexema))
            {
                int column = tablaSimbolo.Rows.Add();
                tablaSimbolo.Rows[column].Cells[0].Value = lexico.Categoria;
                tablaSimbolo.Rows[column].Cells[1].Value = lexico.Lexema;
                tablaSimbolo.Rows[column].Cells[2].Value = lexico.NumeroLinea;
                tablaSimbolo.Rows[column].Cells[3].Value = lexico.PosicionIncial;
                tablaSimbolo.Rows[column].Cells[4].Value = lexico.PosicionFinal;
                lexico = analizador.Analizar();
            }


        }
        private void btnCompilar_Click(object sender, EventArgs e)
        {

        }

        private void Compilador_Load(object sender, EventArgs e)
        {
        }

        
    }
}
