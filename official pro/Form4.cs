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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.lblActive.Text = lblPunto.Text;
            f.lblMoney.Text = txtParat.Text;
            f.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("A jeni te sigurt se dëshironi të mbyllni faqën kryesore ?", "Mbyllja", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form4 f = new Form4();
                f.Close();
                this.Close();
            }
        }

        bool mouseDown;
        private Point offset;
        private void mouseDown_event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

       

        private void Form4_Load(object sender, EventArgs e)
        {
          
            
        }

        private void txtParat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr == 46 && txtParat.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
                MessageBox.Show("Ju lutem shtypni vetem numra ");
            }
        }

        private void lblPunto_Click(object sender, EventArgs e)
        {

        }
    }  
    }
