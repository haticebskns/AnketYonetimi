using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnketYonetimi
{
    public partial class frmLogin : Form
    {
        sqlBaglantisi baglanti = new sqlBaglantisi();
        public int a;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
          

            string kullanici = txtKullanici.Text;
            string sifre = txtSifre.Text;

            baglanti.baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tblKullanici where kullanici=@kullanici and sifre=@sifre", baglanti.baglanti);
            komut.Parameters.AddWithValue("@kullanici", kullanici);
            komut.Parameters.AddWithValue("@sifre", sifre);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                frmCreate create = new frmCreate();
                create.Show();

            }
            else
            {
                MessageBox.Show("Giriş Başarısız!");

            }
            baglanti.baglanti.Close();
            txtKullanici.Text = "admin";
            txtSifre.Text = "test";
        }

        private void loginClosebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        public void anketTurDoldur()
        {
            baglanti.baglanti.Open();

            DataTable tablo = new DataTable("Baslik");
            string sorgu = "Select * from Baslik";
            SqlCommand komut = new SqlCommand(sorgu, baglanti.baglanti);
            SqlDataReader baslikoku = komut.ExecuteReader();
            tablo.Load(baslikoku);

            cbLbaslik.DataSource = tablo;
            cbLbaslik.DisplayMember = "BaslikAdi";
            cbLbaslik.ValueMember = "Id";

            baglanti.baglanti.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            anketTurDoldur();
            cbLbaslik.SelectedIndex = -1;
            cbAnket.SelectedIndex = -1;
            txtKullanici.Text = "admin";
            txtSifre.Text = "test";
            
        }

        private void cbLbaslik_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            baglanti.baglanti.Open();

            DataTable tablo = new DataTable("Anket");
            string sorgu = "Select * from Anket where BaslikId=" + cbLbaslik.SelectedValue +"";
            SqlCommand komut = new SqlCommand(sorgu, baglanti.baglanti);
            SqlDataReader baslikoku = komut.ExecuteReader();
            tablo.Load(baslikoku);

            cbAnket.DisplayMember = "AnketAd";
            cbAnket.ValueMember = "Id";
            cbAnket.DataSource = tablo;

            baglanti.baglanti.Close();
        }
        private void btnAnketac_Click(object sender, EventArgs e)
        {

            frmKayit kayit = new frmKayit();
            kayit.anketid = a;
            kayit.Show();
        }

        private void cbAnket_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = (int)cbAnket.SelectedValue;            
        }
    }
}
