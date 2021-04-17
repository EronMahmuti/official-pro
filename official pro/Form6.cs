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
    public partial class Llogaria : Form
    {
        public Llogaria()
        {
            InitializeComponent();

        }
        
        private void label12_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("A jeni te sigurt se dëshironi të mbyllni faqën e llogarise ?", "Mbyllja", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form4 f = new Form4();
                f.Close();
                this.Close();
            }
        }

        private void btnShtyp_Click(object sender, EventArgs e)
        {
            
            var result = MessageBox.Show("deshironi te perfundoni llogarine ? ", "Pranimi", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
            else if(result == DialogResult.No)
            {
                result = DialogResult.Abort;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            double endTotal = Convert.ToDouble(lbltotal.Text);
            double endMonei = Convert.ToDouble(lblMonei.Text);
            double theEnd = endMonei - endTotal;

            var perfundimi = "Shuma e mbetur = "  + Convert.ToString(theEnd);
            var result = MessageBox.Show(perfundimi, "Perfundimi i orarit ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                this.Close();
            }
            else if (result == DialogResult.No)
            {
                result = DialogResult.Abort;
            }
        }
    }
}
