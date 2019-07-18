using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var ciudad1 = new Ciudad();
            ciudad1.Id = 1;
            ciudad1.Descripcion = "Lima";

            var ciudad2 = new Ciudad();
            ciudad2.Id = 2;
            ciudad2.Descripcion = "Olancho";

            var ciudad3 = new Ciudad();
            ciudad3.Id = 3;
            ciudad3.Descripcion = "Tela";



            var cliente1 = new Cliente();
            cliente1.Id = 1;
            cliente1.Nombre = "Fernando Cordova  ";
            cliente1.Ciudad = ciudad2;
            cliente1.Telefono = 504 | 97612548;
            cliente1.Direccion = "Villas de los Olivos";

            Cliente cliente2 = new Cliente();
            cliente2.Id = 2;
            cliente2.Nombre = "Carlos Zaragoza   ";
            cliente2.Ciudad = ciudad2;
            cliente2.Telefono = 504 | 94512368;
            cliente2.Direccion = "Altos del Carmen";

            Cliente cliente3 = new Cliente();
            cliente3.Id = 3;
            cliente3.Nombre = "Mario Gutierrez";
            cliente3.Ciudad = ciudad2;
            cliente3.Telefono = 504 | 96871256;
            cliente3.Direccion = " Los Laureles";

            Cliente cliente4 = new Cliente();
            cliente4.Id = 4;
            cliente4.Nombre = "Vilma Paredes";
            cliente4.Ciudad = ciudad3;
            cliente4.Telefono = 504 | 36871547;
            cliente4.Direccion = "Colonia La Estacion";

            var listadeCliente = new List<Cliente>();
            listadeCliente.Add(cliente1);
            listadeCliente.Add(cliente2);
            //listadeCliente.Add(cliente3);
            //listadeCliente.Add(cliente4);

            foreach (var c in listadeCliente)
            {
                MessageBox.Show(c.Nombre + "   " + c.Direccion);
            }


        }
    }
}