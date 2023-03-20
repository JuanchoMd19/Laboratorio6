using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    internal class AlquilerVehiculo
    {
        int noAlquiler;
        int nit;
        string placa;
        DateTime fechaAlquiler;
        DateTime fechaDevolucion;
        int kilometrosRecorrido;

        public int Nit { get => nit; set => nit = value; }
        public string Placa { get => placa; set => placa = value; }
        public DateTime FechaAlquiler { get => fechaAlquiler; set => fechaAlquiler = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public int KilometrosRecorrido { get => kilometrosRecorrido; set => kilometrosRecorrido = value; }
        public int NoAlquiler { get => noAlquiler; set => noAlquiler = value; }
    }
}
