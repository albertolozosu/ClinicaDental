using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaDental
{
    public partial class FuncionesEmpleado : Form
    {
        public FuncionesEmpleado()
        {
            InitializeComponent();
        }

        private void FuncionesEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClass.MAIN.Show();
            this.Hide();
        }
    }
}
