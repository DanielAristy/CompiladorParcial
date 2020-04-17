using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompiladorParcial.Transversal;

namespace CompiladorParcial.ManejadorErrores
{
    public class Error : ComponenteLexico
    {
        public String Falla { get; set; }

        public String Causa { get; set; }

        public String Solucion { get; set; }

        public TipoError Tipo { get; set; }

        public Error(string lexema, Categoria categoria, int numeroLinea, int posicionInicial, int posicionFinal,
                string falla, string causa, string solucion, TipoError tipoError)
        {
            Lexema = lexema;
            Categoria = categoria;
            NumeroLinea = numeroLinea;
            PosicionIncial = posicionInicial;
            PosicionFinal = posicionFinal;
            Falla = falla;
            Causa = causa;
            Solucion = solucion;
            Tipo = tipoError;
        }

        public static Error CrearErrorLexico(string lexema, Categoria Categoria, int numeroLinea, int posicionInicial, int posicionFinal,
                string falla, string causa, string solucion)
        {
            return new Error(lexema, Categoria, numeroLinea, posicionInicial, posicionFinal,
                 falla, causa, solucion, TipoError.LEXICO);
        }

        public static Error CrearErrorSemantico(string lexema, Categoria Categoria, int numeroLinea, int posicionInicial, int posicionFinal,
                string falla, string causa, string solucion)
        {
            return new Error(lexema, Categoria, numeroLinea, posicionInicial, posicionFinal,
                 falla, causa, solucion, TipoError.SEMANTICO);
        }

        public static Error CrearErrorSintactico(string lexema, Categoria Categoria, int numeroLinea, int posicionInicial, int posicionFinal,
                string falla, string causa, string solucion)
        {
            return new Error(lexema, Categoria, numeroLinea, posicionInicial, posicionFinal,
                 falla, causa, solucion, TipoError.SINTACTICO);
        }
    }
}
