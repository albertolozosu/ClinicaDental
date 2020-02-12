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
    public partial class FuncionesPaciente : Form
    {
        public FuncionesPaciente()
        {
            InitializeComponent();
        }

        private void FuncionesCD_Load(object sender, EventArgs e)
        {

        }

        private void bttVolvermain_Click(object sender, EventArgs e)
        {
            DataClass.MAIN.Show();
            this.Hide();
        }

        private void listaPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttDardealta_Click(object sender, EventArgs e)
        {

        }
    }
}
