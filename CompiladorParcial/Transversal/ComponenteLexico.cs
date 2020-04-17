using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorParcial.Transversal
{
    class ComponenteLexico
    {
        public String Lexema { get; set; }
        public Categoria Categoria { get; set; }
        public int NumeroLinea { get; set; }
        public int PosicionIncial { get; set; }
        public int PosicionFinal { get; set; }
        public TipoComponente Tipo { get; set; }

    }
}
