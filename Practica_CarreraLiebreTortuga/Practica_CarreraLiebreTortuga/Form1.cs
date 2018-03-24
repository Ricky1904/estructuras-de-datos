using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_CarreraLiebreTortuga
{
    public partial class Form1 : Form
    {
        //Carrera Carrera;
        Tortuga t1;
        Liebre L1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1 = new Tortuga();
            L1 = new Liebre();
           // Carrera = new Carrera(t1);
           
            for (int i = 0; i <=80; i++)
            {
                t1.AvanzarPosicion();
                L1.AvanzarPosicion();
                textBox1.Text += Convert.ToString(t1.ToString() + Environment.NewLine + L1.ToString() + Environment.NewLine);

            }

        }
    }
}
