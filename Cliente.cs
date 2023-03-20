using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    internal class Cliente
    {
        int noCliente;
        int nit;
        string nombreCliente;
        string direccionCliente;

        public int NoCliente { get => noCliente; set => noCliente = value; }
        public int Nit { get => nit; set => nit = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string DireccionCliente { get => direccionCliente; set => direccionCliente = value; }
    }
}
