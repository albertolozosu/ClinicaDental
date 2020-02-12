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
    public partial class Login : Form
    {
        string user="albertolozosu", pass="monlau";
        public Login()
        {
            InitializeComponent();
            checkBox1.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string text = txtPASS.Text;
            if (checkBox1.Checked)
            {
                txtPASS.UseSystemPasswordChar = false;
                txtPASS.Text = text;

            }
            else
            {
                txtPASS.UseSystemPasswordChar = true;
                txtPASS.Text = text;
            }
        
    }

        private void button1_Click(object sender, EventArgs e)
        {
            int count=0;
            if (pass == txtPASS.Text && user == txtUSER.Text)
            {
                DataClass.MAIN.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("The pass or user are not correct");
                txtPASS.Text = "";
                txtUSER.Text = "";
                count++;
            }
            

            
        }
    }
}
