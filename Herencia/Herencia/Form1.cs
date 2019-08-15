using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var heroe1 = new Heroe();
            heroe1.Nombre = "Flash";
            heroe1.Genero = "Hombre";
            heroe1.Descripcion = "Puede recorrer el rededor del mundo en 1 minuto";
            heroe1.SuperPoder = "Super Rapido";
            heroe1.DuracionPoder = "Ilimitado";

            var heroe2 = new Heroe();
            heroe2.Nombre = "La Mole";
            heroe2.Genero = "Hombre";
            heroe2.Descripcion = "Puede demoler lo que sea";
            heroe2.SuperPoder = "Super Fuerza";
            heroe2.DuracionPoder = "Ilimitado";


            var heroe3 = new Heroe();
            heroe3.Nombre = "Tripleflex";
            heroe3.Genero = "Mujer";
            heroe3.Descripcion = "Puede estirarse tres veces el tamano de una jirafa";
            heroe3.SuperPoder = "Flexibilidad";
            heroe3.DuracionPoder = "Limitado(por no estirarse mas)";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var villano1 = new Villano();
            villano1.Nombre = "Octopus";
            villano1.Genero = "Hombre";
            villano1.SuperPoder = "Puede tomar con tentaculos mecanizados, 8 objetos a la ves";
            villano1.Habilidad = "Se escabulle facilmente por cualquier lugar, puede escaparse por hoyos"
            villano1.DuracionPoder = "12 horas";

            var villano2 = new Villano();
            villano2.Nombre = "Triturador";
            villano2.Genero = "Hombre";
            villano2.SuperPoder = "Tritura cualquier tipo de material como ser hierro, metal, piedras y mas";
            villano2.Habilidad = "Puede convertir lo triturado en un arma blanca"
            villano2.DuracionPoder = "Ilimitada";

            var villano3 = new Villano();
            villano3.Nombre = "Bombathor";
            villano3.Genero = "Hombre";
            villano3.SuperPoder = "Crea con sus manos bombas explosivas y bombas atomicas pero estas le llevan mas tiempo";
            villano3.Habilidad = "Se escabulle facilmente por cualquier lugar, puede escaparse por hoyos"
            villano3.DuracionPoder = "De 12 hasta 15 horas";
        }
    }
}
