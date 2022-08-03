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
    public partial class frmKayit : Form
    {
        sqlBaglantisi con= new sqlBaglantisi();
        public List<string> soru = new List<string>();
        public List<string> cevap = new List<string>();
        public List<int> id = new List<int>();
        public List<string> idlist = new List<string>();
        public List<Label> labels = new List<Label>();
        public string sonuc, list;
        GroupBox grb;
        Label lbl;
        int k = 0;


       public int c, anketid, soruid, katilimciId, i; //c:soruId
        public frmKayit()
        {
            InitializeComponent();
        }



        private void frmKayit_Load(object sender, EventArgs e)
        {
            kayitClosebtn.Location = new Point(20, 80);
            Fpnlkayit.Size = new Size(this.Width / 2, this.Height);
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
           
            con.baglanti.Open();
            if (txtKname.Text != "" && txtKlastname.Text != "" && txtKlastname.Text != "" && txtage.Text != "" && txttel.Text != "" && txtKemail.Text != "" && txtcity.Text != "" && cbokul.SelectedIndex != -1)
            {
              
                SqlCommand komut = new SqlCommand();
                komut.Connection = con.baglanti;
                komut.CommandType = CommandType.StoredProcedure;
                komut.CommandText = "katilimciEkle";
                komut.Parameters.Add("Ad", SqlDbType.NVarChar, 50).Value = txtKname.Text;
                komut.Parameters.Add("Soyad", SqlDbType.NVarChar, 100).Value = txtKlastname.Text;
                komut.Parameters.Add("Yas", SqlDbType.Int).Value = txtage.Text;
                komut.Parameters.Add("Tel", SqlDbType.NVarChar, 11).Value = txttel.Text;
                komut.Parameters.Add("Email", SqlDbType.NVarChar, 50).Value = txtKemail.Text;
                komut.Parameters.Add("Sehir", SqlDbType.NVarChar, 13).Value = txtcity.Text;
                komut.Parameters.Add("Egitim", SqlDbType.NVarChar, 50).Value = cbokul.SelectedItem.ToString();
                komut.Parameters.Add("Durum", SqlDbType.Bit).Value = true;
                
                DialogResult result1 = new DialogResult();
                result1 = MessageBox.Show("Kayıt Başarılı. Ankete Başlayabilirsiniz." ,"Anket", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result1==DialogResult.Yes)
                {
                    komut.ExecuteNonQuery();
                    con.baglanti.Close();
                    anketGetir();
                }
            }
            else
            {
                MessageBox.Show("Kayıt Oluşturulamadı. Lütfen tüm alanları doldurduğunuzdan emin olunuz.");
            }

            string sorgu = "select Id from Katilimcilar where Email='" + txtKemail.Text + "'";
            con.baglanti.Open();
            SqlCommand cmd = new SqlCommand(sorgu, con.baglanti);
            SqlDataReader idoku = cmd.ExecuteReader();
            while (idoku.Read())
            {
                katilimciId = Convert.ToInt32(idoku["Id"]);
            }
            con.baglanti.Close();
        }

        private void kayitClosebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void anketGetir()
        {
            con.baglanti.Open();
            string sorgu = "Select Soru, Id from Sorular where AnketId=" + anketid + ""; //Soruları sql'den çektik
            SqlCommand cmd = new SqlCommand(sorgu, con.baglanti);
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                id.Add(Convert.ToInt32(oku["Id"]));
                soru.Add(oku["Soru"].ToString());  //soruları yazdırmak için diziye attım
            }
            con.baglanti.Close();

            for (int i = 0; i < 10; i++) //soruları yazdırma kısmı. her anket 10soruluktur.
            {
                list =id[i].ToString();
                idlist.Add(list);
                grb = new GroupBox();
                grb.Name = grb + i.ToString();
                grb.Size = new Size(Fpnlkayit.Width, 250);
                Fpnlkayit.Controls.Add(grb);                

                lbl= new Label();    //soru label'ları
                labels.Add(lbl);
                lbl.AutoSize = true;
                lbl.Name = i.ToString();
                lbl.Text = (i + 1).ToString() + " - " + soru[i];
                lbl.Location = new Point(20, 100);
               grb.Controls.Add(lbl);

                con.baglanti.Open();                 
                string cvpSorgu = "Select Cevap, TurId from Sorular where Id=" + id[i] + " "; //cevapları sql'den alıyorum
                SqlCommand cvpcmd = new SqlCommand(cvpSorgu, con.baglanti);
                SqlDataReader cevapoku = cvpcmd.ExecuteReader();

                if (cevapoku.Read())
                {

                    c = Convert.ToInt32(cevapoku["TurId"]); //soruların türünü seçtim buna göre cevapları yazdıracağım
                    string cvp = cevapoku["Cevap"].ToString();
                    string[] ayir = cvp.Split("/"); //cevapları ayırıp yazdırmak için diziye atıyorum burda
                    foreach (var item in ayir)
                    {
                        cevap.Add(item);
                    }
                    cevapyaz();
                }
            con.baglanti.Close();
                 
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            sonuc = ((CheckBox)sender).Text;
            cvpEkle();
        }

        private void Rbtn_Click(object sender, EventArgs e)
        {
            sonuc = ((RadioButton)sender).Text;
            cvpEkle();
        }
        public void cvpEkle()
        {
            string[] ayir = idlist[k].Split(" ");
            string sorgu = "insert into Cevaplar(KatilimciId,TurId,AnketId,SoruId,Cevap,Durum) Values('" + katilimciId + "','" + c + "','" + anketid + "', '" +Convert.ToInt32( ayir[0]) + "','" + sonuc + "',1)";
            con.baglanti.Open();
            SqlCommand kmt = new SqlCommand(sorgu, con.baglanti);
            kmt.ExecuteNonQuery();
            con.baglanti.Close();
            k++;
        }
        public void cevapyaz()
        {
            switch (c)
            {
                case 1:                         //Çoktan seçmeli
                    for (int k = 0; k < cevap.Count; k++)
                    {

                        RadioButton rbtn = new RadioButton();
                        rbtn.Text = cevap[k];
                        rbtn.Location = new Point(20 + (k * 300), 150);
                        rbtn.AutoSize = true;
                        rbtn.Click += Rbtn_Click;
                        grb.Controls.Add(rbtn);
                    }

                    break;
                case 2:                     //çok yaıtlı
                    for (int k = 0; k < cevap.Count; k++)
                    {
                        CheckBox check = new CheckBox();
                        check.Location = new Point(20 + (k * 300), 150);
                        check.Text = cevap[k];
                        check.AutoSize = true;
                        check.Click += Check_Click;
                        grb.Controls.Add(check);
                    }
                    break;
                case 3:                                //Eşleştirme Şıkları     
                    for (int k = 0; k < cevap.Count; k++)
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
                    for (int k = 0; k < cevap.Count; k++)
                    {
                        RichTextBox Rtxt = new RichTextBox();
                        Rtxt.Location = new Point(20, 50);
                        grb.Controls.Add(Rtxt);
                    }
                    break;
                case 6:                         //Görsel seçmeli sorular
                    for (int k = 0; k < cevap.Count; k++)
                    {
                        CheckBox check = new CheckBox();
                        check.Location = new Point(20 + (k * 300), 150);
                        check.Text = cevap[k];
                        check.AutoSize = true;
                        grb.Controls.Add(check);
                    }
                    break;
            }
            cevap.Clear();
        }
    }
}
