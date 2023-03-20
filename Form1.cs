using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio6
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<DatoVehiculo> datosVehiculos = new List<DatoVehiculo>();
        public Form1()
        {
            InitializeComponent();
            leerCliente();
            mostrarCliente();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void leerCliente()
        {
            FileStream stream = new FileStream("Cliente.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Cliente cliente = new Cliente();
                cliente.NoCliente = Convert.ToInt32(reader.ReadLine());
                cliente.Nit = Convert.ToInt32(reader.ReadLine());
                cliente.NombreCliente = reader.ReadLine();
                cliente.DireccionCliente = reader.ReadLine();
                clientes.Add(cliente);
            }
            reader.Close();
        }

        private void mostrarCliente()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clientes;
            dataGridView1.Refresh();
        }

        private void btnIngresarVehiculo_Click(object sender, EventArgs e)
        {
            int numeroVehiculo = 1; 
            bool encontrado = false;
            for (int i = 0; i < datosVehiculos.Count; i++)
            {
                if (datosVehiculos[i].Placa == txtPlaca.Text)
                {
                    encontrado = true;
                }
            }
            DatoVehiculo dVRepetida = datosVehiculos.Find(p => p.Placa == txtPlaca.Text);

            if (dVRepetida == null)
            {
                DatoVehiculo datoVehiculo = new DatoVehiculo();
                datoVehiculo.NoVehiculo = numeroVehiculo; 
                datoVehiculo.Placa = txtPlaca.Text;
                datoVehiculo.Marca = txtMarca.Text;
                datoVehiculo.Modelo = txtModelo.Text;
                datoVehiculo.Color = txtColor.Text;
                datoVehiculo.PrecioKilometro = txtPrecioKilometro.Text;

                datosVehiculos.Add(datoVehiculo);
            }
            else
            {
                MessageBox.Show(dVRepetida.Placa + " Vehículo ya existente");
            }
            mostrarDatoVehiculo();
        }

        private void mostrarDatoVehiculo()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = datosVehiculos;
            dataGridView2.Refresh();
        }

        private void guardaDatoVehiculo(string fileName)
        {

            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (var datoVehiculo in datosVehiculos)
            {
                writer.WriteLine(datoVehiculo.NoVehiculo);
                writer.WriteLine(datoVehiculo.Placa);
                writer.WriteLine(datoVehiculo.Marca);
                writer.WriteLine(datoVehiculo.Modelo);
                writer.WriteLine(datoVehiculo.Color);
                writer.WriteLine(datoVehiculo.PrecioKilometro);
            }

            writer.Close();
        }

        private void btnGuardarDatoVehiculo_Click(object sender, EventArgs e)
        {
            guardaDatoVehiculo("DatoVehiculo.txt");
            MessageBox.Show("Archivo Guardado");
        }
    }
}
