using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AnketYonetimi
{
    public partial class frmAnketOlusturma : Form
    {
        sqlBaglantisi con = new sqlBaglantisi();
        public DateTime olusturulmaTarihi = DateTime.Now;
        int baslikId , anketId, soruno=0;
        public string anketadi, cvp ;
        GroupBox grb;
        Label lbl;
        public frmAnketOlusturma()
        {
            InitializeComponent();
        }

        private void kayitClosebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAnketOlusturma_Load(object sender, EventArgs e)
        {
            kayitClosebtn.Location=new Point(this.Width-50,50);
            grbxOsoru.Size = new Size(this.Width, 400);
            label4.Location = new Point(900, 50);
            txtOsık.Location = new Point(900, 80);
            btnOsık.Location = new Point(1550, 80);
            lbxOsıklar.Location = new Point(900, 150);
            btnOolustur.Location = new Point(950, 30);
            btnOsoru.Location = new Point(100,200);
            lbxOsıklar.Size = new Size(190, 250);
           
            cbturDoldur();
            cbanketturdoldur();
            cbOankettur.SelectedIndex = -1;
            cbOOsorutur.SelectedIndex = -1;
            grbxOsoru.Visible = false;
            Fpnlolusturma.Visible = false;
            cbOOsorutur.Enabled = false;

        }
        public void cbturDoldur()
        {

            con.baglanti.Open();

            DataTable tablo1 = new DataTable("Sorutur");
            string sorgu = "Select TurAdi, Id from Sorutur";
            SqlCommand komut = new SqlCommand(sorgu, con.baglanti);
            SqlDataReader baslikoku = komut.ExecuteReader();
            tablo1.Load(baslikoku);


            cbOOsorutur.DisplayMember = "TurAdi";
            cbOOsorutur.ValueMember = "Id";
            cbOOsorutur.DataSource = tablo1;

            con.baglanti.Close();
        }
        public void cbanketturdoldur()
        {
            con.baglanti.Open();

            DataTable tablo = new DataTable("Baslik");
            string sorgu = "Select * from Baslik";
            SqlCommand komut = new SqlCommand(sorgu, con.baglanti);
            SqlDataReader baslikoku = komut.ExecuteReader();
            tablo.Load(baslikoku);


            cbOankettur.DisplayMember = "BaslikAdi";
            cbOankettur.ValueMember = "Id";
            cbOankettur.DataSource = tablo;
            con.baglanti.Close();
        }
        private void btnOolustur_Click(object sender, EventArgs e)
        {
            anketadi = txtAnketAdi.Text;
            string sorgu = "insert into Anket(AnketAd,BaslikId,YayinTarihi,Sure,Durum) Values('" + txtAnketAdi.Text + "'," + baslikId + ", '"+ olusturulmaTarihi + "' , "+ Convert.ToInt32(txtOsure.Text) +",1)";
            con.baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, con.baglanti);
            komut.ExecuteNonQuery();
            con.baglanti.Close();
            MessageBox.Show(txtAnketAdi.Text+" Anketi için soru ekleyin.");

            cbOankettur.Enabled = false;
            txtAnketAdi.Enabled = false;
            txtOsure.Enabled = false;
            grbxOsoru.Visible = true;
            Fpnlolusturma.Visible = true;
            cbOOsorutur.Enabled = true;

        }
        private void cbOankettur_SelectedIndexChanged(object sender, EventArgs e)
        {
            baslikId =Convert.ToInt32( cbOankettur.SelectedValue);
        }
        public void soruYaz()
        {
            string cvp = " ";
            for (int i = 0; i < lbxOsıklar.Items.Count; i++)
            {
                cvp += lbxOsıklar.Items[i].ToString() + "/";
            }

            if (rtxtAsoru.Text != " " && cvp != " ")
            {
                string sorgu = "insert into Sorular(TurId,AnketId,Soru,Durum,Cevap) values(" + cbOOsorutur.SelectedValue + ", " + anketid() + ",'" + rtxtAsoru.Text + "',1,'" + cvp + "')";
                con.baglanti.Open();
                SqlCommand sqlcmd = new SqlCommand(sorgu, con.baglanti);
                sqlcmd.ExecuteNonQuery();
                con.baglanti.Close();
            }
        }

        private void btnOremove_Click(object sender, EventArgs e)
        {
            lbxOsıklar.Items.Remove(lbxOsıklar.SelectedItem);
        }

        private void btnOsık_Click(object sender, EventArgs e)
        {

            if (txtOsık.Text!= "")
            {
                lbxOsıklar.Items.Add(txtOsık.Text);
            }
            else
            {
                MessageBox.Show("Şıklar boş olamz. lütfen şık ekleyiniz.");
            }
            txtOsık.Clear();

        }
        private void btnOsoru_Click(object sender, EventArgs e)
        {           
            if (soruno < 10)
            {
               
                soruYaz();
                soruGetir();
                MessageBox.Show((soruno+1) + ". soru eklendi");
                lbxOsıklar.Items.Clear();
                soruno++;
            }
            else
            {
                MessageBox.Show("Her anket 10 sorudur. 10 soruyu tamamladınız.");
            }
        }
        int anketid()
        {
            string sorgu = "select Id from Anket where AnketAd='" + anketadi + "'";
            con.baglanti.Open();
            SqlCommand cmd = new SqlCommand(sorgu, con.baglanti);
            SqlDataReader idoku = cmd.ExecuteReader();
            if (idoku.Read())
            {
                anketId = Convert.ToInt32(idoku["Id"]);
            }
            con.baglanti.Close();
            return anketId;
        }

        public void soruGetir()
        {
            grb = new GroupBox();
            grb.Name = grb + soruno.ToString();
            grb.Size = new Size(Fpnlolusturma.Width, 250);
            Fpnlolusturma.Controls.Add(grb);

            lbl = new Label();    //soru label'ları
            lbl.AutoSize = true;
            lbl.Name = soruno.ToString();
            lbl.Text = (soruno + 1).ToString() + " - " + rtxtAsoru.Text;
            lbl.Location = new Point(20, 100);
            grb.Controls.Add(lbl);

                switch (cbOOsorutur.SelectedValue)
                {
                    case 1:                         //Çoktan seçmeli
                        for (int k = 0; k < lbxOsıklar.Items.Count; k++)
                        {

                            RadioButton rbtn = new RadioButton();
                            rbtn.Text = lbxOsıklar.Items[k].ToString();
                            rbtn.Location = new Point(20 + (k * 300), 150);
                            rbtn.AutoSize = true;
                            grb.Controls.Add(rbtn);
                        }

                        break;
                    case 2:                     //çok yaıtlı
                        for (int k = 0; k < lbxOsıklar.Items.Count; k++)
                        {
                            CheckBox check = new CheckBox();
                            check.Location = new Point(20 + (k * 300), 150);
                            check.Text = lbxOsıklar.Items[k].ToString();
                            check.AutoSize = true;
                            grb.Controls.Add(check);
                        }
                        break;
                    case 3:                                //Eşleştirme Şıkları     
                        for (int k = 0; k < lbxOsıklar.Items.Count; k++)
                        {
                            ListBox listBox = new ListBox();
                            listBox.Location = new Point(20 + (k * 300), 150);
                            listBox.AutoSize = true;
                            grb.Controls.Add(listBox);
                        }
                        break;
                    case 4:                                     //boşluk doldurma
                        for (int k = 0; k < 1; k++)
                        {
                            ListBox listBox = new ListBox();
                            listBox.Location = new Point(20 + (k * 300), 150);

                            listBox.AutoSize = true;
                            grb.Controls.Add(listBox);
                        }
                        break;
                    case 5:                             //Açık uçlu
                        for (int k = 0; k < lbxOsıklar.Items.Count; k++)
                        {
                            RichTextBox Rtxt = new RichTextBox();
                            Rtxt.Location = new Point(20, 50);
                            grb.Controls.Add(Rtxt);
                        }
                        break;
                    case 6:                         //Görsel seçmeli sorular
                        for (int k = 0; k < lbxOsıklar.Items.Count; k++)
                        {
                            CheckBox check = new CheckBox();
                            check.Location = new Point(20 + (k * 300), 150);
                            check.Text = lbxOsıklar.Items[k].ToString();
                            check.AutoSize = true;
                            grb.Controls.Add(check);
                        }
                        break;
                }
            
        }
    }
}
