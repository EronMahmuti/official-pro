using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace official_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyData.LoadUsers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (MyData.users.Where(
                 t => t.Username == txtPuntori.Text &&
                 t.Password == txtPassword.Text &&
                 t.StatusId == 1).Count() > 0)
            {
                //hapim formen kryesore
                Form4 f = new Form4();
                f.lblPunto.Text = txtPuntori.Text;
                this.Hide();
                f.Show();
            }else if (MyData.users.Where(
                 t => t.Username == txtPuntori.Text &&
                 t.Password == txtPassword.Text &&
                 t.StatusId == 2).Count() > 0)
            {
                Form7 f = new Form7();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Te dhenat nuk jane valide!");
            }

        }
    }
}
