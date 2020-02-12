using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLLBUENO;

namespace ClinicaDental
{
    public partial class FuncionesMedico : Form
    {
        public string name, secname, dni, gmail, tel, street;
      
         ClassDoctor doc = new ClassDoctor("Roger", "eskere", "987654321P", "Rogereskere@monlau.com", "987654321", "Calle Cpillin",1000);
        public FuncionesMedico()
        {
            InitializeComponent();
            txtTel.MaxLength = 9;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DataClass.MAIN.Show();
            this.Hide();
        }

        private void bttDardealta_Click(object sender, EventArgs e)
        {
          
            
           
            listaMedico.Items.Add(doc.Nombre);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                
            }
            else
     if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void FuncionesMedico_Load(object sender, EventArgs e)
        {

        }
    }
}
