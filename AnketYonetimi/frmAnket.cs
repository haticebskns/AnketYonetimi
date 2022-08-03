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
    public partial class frmAnket : Form
    {
        sqlBaglantisi con = new sqlBaglantisi();
       public List<string> soru = new List<string>();
       public List<string> cevap = new List<string>();
       public List<int> id = new List<int>();
      


       public int anketid , b, c;          //a=anketId, b=sorutürId

        public frmAnket()
        {
            InitializeComponent();
        }

        private void frmAnket_Load(object sender, EventArgs e)
        {
            FpnlAnket.Size = new Size(this.Width, this.Height-70);
            FpnlAnket.Location = new Point(this.Width, 70);
            AClosebtn.Location = new Point(FpnlAnket.Width - 50, 40);
            SoruYaz();
        }

        private void AClosebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SoruYaz()
        {
            
            con.baglanti.Open();
            string sorgu = "Select Soru, Id from Sorular where AnketId=" + anketid + ""; //Soruları sql'den çektik
            SqlCommand cmd = new SqlCommand(sorgu, con.baglanti);
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
               id.Add( Convert.ToInt32(oku["Id"]));              
                soru.Add(oku["Soru"].ToString());  //soruları yazdırmak için diziye attım
            }
            con.baglanti.Close();

            for (int i = 0; i < 10; i++) //soruları yazdırma kısmı. her anket 10soruluktur.
            {
                GroupBox grb = new GroupBox();
                grb.Name =grb+b.ToString();
                grb.Size = new Size(FpnlAnket.Width, 250);
                
                FpnlAnket.Controls.Add(grb);

                Label lbl = new Label();    //soru label'ları
                lbl.AutoSize = true;
                lbl.Text = (i + 1).ToString() + " - " + soru[i];
                lbl.Location = new Point(20, 100);
                grb.Controls.Add(lbl);

                con.baglanti.Close();
                con.baglanti.Open();
                string cvpSorgu = "Select Cevap, TurId from Sorular where Id=" + id[i] + " "; //cevapları sql'den alıyorum
                SqlCommand cvpcmd = new SqlCommand(cvpSorgu, con.baglanti);
                SqlDataReader cevapoku = cvpcmd.ExecuteReader();

                while (cevapoku.Read())
                {

                    c = Convert.ToInt32(cevapoku["TurId"]); //soruların türünü seçtim buna göre cevapları yazdıracağım
                    string cvp = cevapoku["Cevap"].ToString();
                    string[] ayir = cvp.Split("/"); //cevapları ayırıp yazdırmak için diziye atıyorum burda
                    foreach (var item in ayir)
                    {
                        cevap.Add(item);
                    }

                    switch (c)
                    {
                        case 1:                         //Çoktan seçmeli
                            for (int k = 0; k < cevap.Count; k++)
                            {

                                RadioButton rbtn = new RadioButton();
                                rbtn.Text = cevap[k];
                                rbtn.Location = new Point(20 + (k * 300), 150);
                                rbtn.AutoSize = true;
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
                                grb.Controls.Add(check);
                            }
                            break;
                        case 3:                                //Eşleştirme Şıkları     

                                ListBox listBox = new ListBox();
                                listBox.Location = new Point(20 , 150);
                                listBox.Items.Add(cevap);
                                listBox.AutoSize = true;
                                grb.Controls.Add(listBox);
                            
                            break;
                        case 4:                                     //boşluk doldurma
                            for (int k = 0; k < 1; k++)
                            {

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
    }
}
