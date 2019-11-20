using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinariaMenu
{
    public partial class Veterinario : Form
    {
        public Veterinario()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Veterinario_Load(object sender, EventArgs e)
        {

        }
        private void limpiar()
        {
            txtmatricula.Clear();
            txtape.Clear();
            txtnomb.Clear();
            txtdireccion.Clear();
            txtemail.Clear();
            txttel.Clear();
            txtnrodocu.Clear();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
