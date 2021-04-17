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
    
    public partial class Form5 : Form
    {
        Shitesit sh = new Shitesit();
        ConnectDB cdb = new ConnectDB();

        string Bakeri;
        string Mesing;
        string Alumin;
        string Lemenka, Plumi, Akumlator, Shishe, Rosfaj, Heker, Kese, Shitesi;
        string vleraLemenka, vleraPlumi, vleraAkumlator,
            vleraShishe, vleraRosfaj, vleraHeker, vleraKese, vleraBakeri, vleraMesing, vleraAlumin;
        double alu, baku, mesi, lemi, lumi, tori, rosi, heki, ishj, qese, totali;
        

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.shitesitTableAdapter.FillBy(this.demoDbDataSet.Shitesit);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demoDbDataSet.Shitesit' table. You can move, or remove it, as needed.
            this.shitesitTableAdapter.Fill(this.demoDbDataSet.Shitesit);

        }

        private void txtLemenka_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr == 46 && txtLemenka.Text.IndexOf('.') != -1)
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

        private void txtPlumi_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr == 46 && txtPlumi.Text.IndexOf('.') != -1)
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

        private void txtAkumlator_KeyPress(object sender, KeyPressEventArgs e)
        {

            Char chr = e.KeyChar;
            if (chr == 46 && txtAkumlator.Text.IndexOf('.') != -1)
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

        private void txtRosfaj_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr == 46 && txtRosfaj.Text.IndexOf('.') != -1)
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

        private void txtHeker_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr == 46 && txtHeker.Text.IndexOf('.') != -1)
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

        private void txtShishe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr == 46 && txtShishe.Text.IndexOf('.') != -1)
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

        private void txtKese_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr == 46 && txtKese.Text.IndexOf('.') != -1)
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

        private void txtAlumin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr == 46 && txtAlumin.Text.IndexOf('.') != -1)
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

        private void txtShitesi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ju lutem Shtypni vetem shkronja ");
            }
        }

        private void txtMesing_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if(chr == 46 && txtMesing.Text.IndexOf('.') != -1)
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
        private void txtBaker_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr == 46 && txtBaker.Text.IndexOf('.') != -1)
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
        private void label12_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("A jeni te sigurt se dëshironi të mbyllni faqën kryesore ?", "Mbyllja", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
        }


        public void rezultati()
        {
            Bakeri = this.txtBaker.Text.ToString();
            Mesing = this.txtMesing.Text.ToString();
            Alumin = this.txtAlumin.Text.ToString();
            Lemenka = this.txtLemenka.Text.ToString();
            Plumi = this.txtPlumi.Text.ToString();
            Akumlator = this.txtAkumlator.Text.ToString();
            Shishe = this.txtShishe.Text.ToString();
            Rosfaj = this.txtRosfaj.Text.ToString();
            Heker = this.txtHeker.Text.ToString();
            Kese = this.txtKese.Text.ToString();
            Shitesi = this.txtShitesi.Text.ToString();

            sh.Blersi = lblActive.Text;
            sh.emriShitesit = txtShitesi.Text;
            sh.shumaShitesit = totali;
            sh.dataDheKoha = DateTime.Now;

            bool success = cdb.Insert(sh);

            vleraBakeri = Bakeri;
            vleraMesing = Mesing;
            vleraAlumin = Alumin;
            vleraLemenka = Lemenka;
            vleraPlumi = Plumi;
            vleraAkumlator = Akumlator;
            vleraShishe = Shishe;
            vleraRosfaj = Rosfaj;
            vleraHeker = Heker;
            vleraKese = Kese;

        }
        public void unaza()
        {
            for (int i = 0; i <= 9; i++)
            {
                if (string.IsNullOrEmpty(Bakeri))
                {
                    Bakeri = "0";
                }
                else if (string.IsNullOrEmpty(Mesing))
                {
                    Mesing = "0";
                }
                else if (string.IsNullOrEmpty(Alumin))
                {
                    Alumin = "0";
                }
                else if (string.IsNullOrEmpty(Lemenka))
                {
                    Lemenka = "0";
                }
                else if (string.IsNullOrEmpty(Plumi))
                {
                    Plumi = "0";
                }
                else if (string.IsNullOrEmpty(Akumlator))
                {
                    Akumlator = "0";
                }
                else if (string.IsNullOrEmpty(Rosfaj))
                {
                    Rosfaj = "0";
                }
                else if (string.IsNullOrEmpty(Heker))
                {
                    Heker = "0";
                }
                else if (string.IsNullOrEmpty(Shishe))
                {
                    Shishe = "0";
                }
                else if (string.IsNullOrEmpty(Kese))
                {
                    Kese = "0";
                }
            }
        }
        public void mbledhja()
        {
            mesi = Convert.ToDouble(Mesing) * 2;
            baku = Convert.ToDouble(Bakeri) * 3.5;
            alu = Convert.ToDouble(Alumin) * 0.7;
            lemi = Convert.ToDouble(Lemenka) * 0.5;
            lumi = Convert.ToDouble(Plumi) * 0.8;
            tori = Convert.ToDouble(Akumlator) * 0.45;
            rosi = Convert.ToDouble(Rosfaj) * 0.55;
            heki = Convert.ToDouble(Heker) * 0.12;
            ishj = Convert.ToDouble(Shishe) * 0.14;
            qese = Convert.ToDouble(Kese) * 0.10;

            totali = mesi + baku + alu + lemi + lumi + tori + rosi + heki + ishj + qese;

        }
        public void rikthimi()
        {
            Lemenka = Convert.ToString(lemi);
            Plumi = Convert.ToString(lumi);
            Akumlator = Convert.ToString(tori);
            Shishe = Convert.ToString(ishj);
            Rosfaj = Convert.ToString(rosi);
            Heker = Convert.ToString(heki);
            Kese = Convert.ToString(qese);
            Mesing = Convert.ToString(mesi);
            Bakeri = Convert.ToString(baku);
            Alumin = Convert.ToString(alu);
        }
        public void pasimi()
        {
            txtBaker.Text = "0";
            txtMesing.Text = "0";
            txtAlumin.Text = "0";
            txtLemenka.Text = "0";
            txtPlumi.Text = "0";
            txtAkumlator.Text = "0";
            txtShishe.Text = "0";
            txtRosfaj.Text = "0";
            txtHeker.Text = "0";
            txtKese.Text = "0";
            txtShitesi.Text = null;
        }
        public Form5()
        {
            InitializeComponent();
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            rezultati();
            unaza();
            mbledhja();
            rikthimi();
            var data = DateTime.Now.ToString();
            var treta = "\n baker >>  " + vleraBakeri + " * 3.5 = " + Bakeri + 
                "\n mesing >>  " + vleraMesing + " * 2 = " + Mesing +
                "\n alumin >>  " + vleraAlumin + " * 0.70 = " + Alumin + 
                "\n akumlator >>  " + vleraAkumlator + " * 0.45 = " + Akumlator + 
                "\n rosfaj >>  " + vleraRosfaj + " * 0.55 = " + Rosfaj +
                "\n Plum >>  " + vleraPlumi + " * 0.80 = " + Plumi + 
                "\n Lemenka >>  " + vleraLemenka + " * 0.50 = " + Lemenka + 
                "\n Hekra >>  " + vleraHeker + " * 0.12 = " + Heker +
                "\n Shishe >>  " + vleraShishe + " * 0.14 = " + Shishe + 
                "\n Kese >>  " + vleraKese + " * 0.10 = " + Kese + 
                "\n TOTALI = " + totali + " €";
            var katerta = " Sigurohni që vlerat jane korrekte " + treta;
            var result = MessageBox.Show(katerta, "konfirmimi", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                result = MessageBox.Show("ju refuzuat", "refuzimi");
            }
            else if (result == DialogResult.Yes)
            {
                
                Llogaria f = new Llogaria();
                f.lblBaker.Text = Bakeri + " €";
                f.lblMesing.Text = Mesing + " €";
                f.lblAlumin.Text = Alumin  + " €";
                f.lblemenka.Text = Lemenka  + " €";
                f.lblPlum.Text = Plumi  + " €";
                f.lblAkumlator.Text = Akumlator  + " €";
                f.lblHeker.Text = Heker  + " €";
                f.lblShishe.Text = Shishe  + " €";
                f.lblQese.Text = Kese  + " €";
                f.lblRosfaj.Text = Rosfaj  + " €";
                f.lblShitesi.Text = Shitesi  + " €";
                f.lblDate.Text = data;
                f.lblActive.Text = lblActive.Text;
                f.lblMonei.Text = lblMoney.Text;
                f.lbltotal.Text = Convert.ToString(totali);
                //Perfundimi = arr.Sum();

                pasimi();
                f.ShowDialog();
                


            }
            try
            {
                this.shitesitTableAdapter.FillBy(this.demoDbDataSet.Shitesit);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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
        
    }
}
