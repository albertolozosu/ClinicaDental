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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void bttVolverLogin_Click(object sender, EventArgs e)
        {
            DataClass.Log_in.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataClass.FuncionesPaciente.Show();
            this.Hide();
        }

        private void bttMedico_Click(object sender, EventArgs e)
        {
            DataClass.FuncionesMedico.Show();
            this.Hide();
        }

        private void bttEmpleado_Click(object sender, EventArgs e)
        {
            DataClass.FuncionesEmpleado.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
