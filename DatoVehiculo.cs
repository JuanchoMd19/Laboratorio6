using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    internal class DatoVehiculo
    {
        int noVehiculo; 
        string placa;
        string marca;
        string modelo;
        string color;
        string precioKilometro;

        public int NoVehiculo { get => noVehiculo; set => noVehiculo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public string PrecioKilometro { get => precioKilometro; set => precioKilometro = value; }
    }
}
