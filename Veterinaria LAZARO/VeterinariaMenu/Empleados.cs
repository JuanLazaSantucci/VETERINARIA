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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            txtnroemp.Clear();
            txtape.Clear();
            txtnomb.Clear();
            txtdireccio.Clear();
            txtemail.Clear();
            txttel.Clear();
            txtnrodoc.Clear();
        }
        public void habilitar(bool x)
        {
            txtnroemp.Enabled = x;
            txtape.Enabled = x;
            txtdireccio.Enabled = x;
            txtemail.Enabled = x;
            txttel.Enabled = x;
            txtnomb.Enabled = x;
            txtnrodoc.Enabled = x;
            btnmodificar.Enabled = x;
            btnlimpiar.Enabled = !x;

            btnmodificar.Enabled = !x;
            btneliminar.Enabled = !x;
            btnlimpiar.Enabled = x;
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            habilitar(false);
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            habilitar(true);
        }
    }
}
