using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompiladorParcial.Caches;
using CompiladorParcial.Transversal;

namespace CompiladorParcial.AnalisisLexico
{
    public class AnalizadorLexico
    {
        private int NumeroLineaActual;
        private int Puntero;
        private String CaracterActual;
        private Linea LineaActual;
        String Lexema;

        public AnalisisLexico()
        {
            NumeroLineaActual = 0;
            CargarNuevaLinea();
        }

        private void CargarNuevaLinea()
        {
            NumeroLineaActual = NumeroLineaActual + 1;

            
            LineaActual = Cache.ObtenerLinea(NumeroLineaActual);

            if (LineaActual.Contenido.Equals("@EOF@"))
            {
                NumeroLineaActual = LineaActual.Numero;
            }

            Puntero = 1;
        }

        private void LeerSiguienteCaracter()
        {

            if ("@EOF@".Equals(LineaActual.Contenido))
            {
                CaracterActual = LineaActual.Contenido;

            }
            else if (Puntero > LineaActual.Contenido.Length)
            {
                CaracterActual = "@FL@";
                Puntero++;
            }
            else
            {
                CaracterActual = LineaActual.Contenido.Substring(Puntero - 1, 1);
                Puntero = Puntero + 1;
            }

        }
        private void ConcatenarLexema()
        {
            Lexema = Lexema + CaracterActual;
        }
        private void LimpiarLexema()
        {
            Lexema = "";
        }
        private void DevorarEspaciosBlanco()
        {
            while (CaracterActual.Equals(" "))
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
