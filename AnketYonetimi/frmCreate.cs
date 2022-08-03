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
    public partial class frmCreate : Form
    {
        sqlBaglantisi con = new sqlBaglantisi();
        public int anketId;
        public frmCreate()
        {
            InitializeComponent();
        }

        private void kayitClosebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCKayit_Click(object sender, EventArgs e)
        {
            frmKayit kayit = new frmKayit();
            kayit.ShowDialog();
        }

        private void frmCreate_Load(object sender, EventArgs e)
        {
            cbturDoldur();

        }

        private void btnCekle_Click(object sender, EventArgs e)
        {
            frmAnketOlusturma olustur = new frmAnketOlusturma();
            olustur.Show();
        }

        private void btnCara_Click(object sender, EventArgs e)
        {
            con.baglanti.Open();
            string sorgu = "Select Id, AnketAd as 'Anket Adı: ', YayinTarihi as 'Başlangıç Tarihi: ' from Anket where BaslikId="+ Convert.ToInt32(cbCankettur.SelectedValue) +" ";
            DataTable liste = new DataTable("Anket");
            SqlDataAdapter getir = new SqlDataAdapter(sorgu, con.baglanti);
            getir.Fill(liste);
            dgvcontent.DataSource = liste;

            con.baglanti.Close();

        }

        public void cbturDoldur()
        {            
            con.baglanti.Open();

            DataTable tablo = new DataTable("Baslik");
            string sorgu = "Select BaslikAdi, Id from Baslik";
            SqlCommand komut = new SqlCommand(sorgu, con.baglanti);
            SqlDataReader baslikoku = komut.ExecuteReader();
            tablo.Load(baslikoku);


            cbCankettur.DisplayMember = "BaslikAdi";
            cbCankettur.ValueMember = "Id";
            cbCankettur.DataSource = tablo;

            con.baglanti.Close();
        }

        private void dgvcontent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            frmAnket anket = new frmAnket();
            anket.anketid = Convert.ToInt32(dgvcontent.CurrentRow.Cells["Id"].Value);
            anket.Show();
        }

        private void btnOoku_Click(object sender, EventArgs e)
        {
            frmResult rslt = new frmResult();
            rslt.Show();
        }
    }
}
