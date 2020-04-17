using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompiladorParcial.Caches;
using CompiladorParcial.Transversal;
using CompiladorParcial.TablaSimbolos;

namespace CompiladorParcial.AnalisisLexico
{
    public class AnalizadorLexico
    {
        public int numeroLineaActual { get; set; }
        public int puntero { get; set; }
        public String caracterActual { get; set; }
        public Linea lineaActual { get; set; }
        String lexema;

        public AnalizadorLexico()
        {
            numeroLineaActual = 0;
            CargarNuevaLinea();
        }

        private void CargarNuevaLinea()
        {
            numeroLineaActual = numeroLineaActual + 1;

            
            lineaActual = Cache.ObtenerLinea(numeroLineaActual);

            if (lineaActual.Contenido.Equals("@EOF@"))
            {
                numeroLineaActual = lineaActual.Numero;
            }

            puntero = 1;
        }

        private void DevolverPuntero()
        {
            puntero = puntero - 1;
        }

        private void LeerSiguienteCaracter()
        {

            if ("@EOF@".Equals(lineaActual.Contenido))
            {
                caracterActual = lineaActual.Contenido;

            }
            else if (puntero > lineaActual.Contenido.Length)
            {
                caracterActual = "@FL@";
                puntero++;
            }
            else
            {
                caracterActual = lineaActual.Contenido.Substring(puntero - 1, 1);
                puntero++;
            }

        }
        private void concatenarLexema()
        {
            lexema = lexema + caracterActual;
        }
        private void LimpiarLexema()
        {
            lexema = "";
        }
        private void DevorarEspaciosBlanco()
        {
            while (caracterActual.Equals(" "))
            {
                LeerSiguienteCaracter();
            }
        }
        public bool EsLetra(String simbolo)
        {
            return Char.IsLetter(simbolo, 0);
        }
        public bool EsDigito(String simbolo)
        {
            return Char.IsDigit(simbolo, 0);
        }

        public bool EsLetraODigito(String simbolo)
        {
            return EsLetra(simbolo) || EsDigito(simbolo);
        }

        public ComponenteLexico Analizar()
        {
            ComponenteLexico componenteLexico = new ComponenteLexico();
            LimpiarLexema();
            int estadoActual = 0;
            bool continuarAnalisis = true;

            while (continuarAnalisis)
            {
                
            }
            if (componenteLexico.Equals("@EOF@"))
            {
                //TablaMaestra.ObtenerTablaMaestra().Sincronizar(componente);
                TablaMaestra.SincronizarSimbolo(componenteLexico);
            }

            return componenteLexico;
        }

    }
}
