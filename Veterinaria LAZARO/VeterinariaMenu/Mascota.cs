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
    public partial class Mascota : Form
    {
        public Mascota()
        {
            InitializeComponent();
        }

        private void Mascota_Load(object sender, EventArgs e)
        {
            habilitar(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
        public void habilitar(bool x)
        {
            txtnrolista.Enabled = x;
            txtnombredue.Enabled = x;
            txtdireccion.Enabled = x;
            txtnombmasc.Enabled = x;
            txtedadmasc.Enabled = x;
            cmbsexmasc.Enabled = x;
            txttipoanimal.Enabled = x;
            btnmodificar.Enabled = x;

            btnmodificar.Enabled = !x;
        }
        private void limpiar()
        {
            txtnrolista.Clear();
            txttipoanimal.Clear();
            cmbsexmasc.SelectedIndex = -1;
            txtnombredue.Clear();
            txtdireccion.Clear();
            txtedadmasc.Clear();
            txtnombmasc.Clear();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
