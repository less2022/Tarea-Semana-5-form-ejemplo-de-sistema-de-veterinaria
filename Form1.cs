using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_Semana_5_form_ejemplo_de_sistema_de_veterinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos c = new Datos();
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Diagnostico c = new Diagnostico();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          Medicamentos c = new Medicamentos();
            c.Show();
        }
    }

    }

