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
    public partial class frmResult : Form
    {
        sqlBaglantisi con = new sqlBaglantisi();
        public int Ranketid;
        public frmResult()
        {
            InitializeComponent();
        }

        private void btnRclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void gosterge()
        {
           
        }

        private void btnRsonuc_Click(object sender, EventArgs e)
        {
            string sorgu = "select distinct KatilimciId from Cevaplar where AnketId=" + Ranketid + "";
            DataTable dataTable = new DataTable("Cevaplar");
            SqlDataAdapter aData = new SqlDataAdapter(sorgu, con.baglanti);
            aData.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        public void cbturDoldur()
        {

            con.baglanti.Open();

            DataTable tablo = new DataTable("Anket");
            string sorgu = "Select AnketAd, Id from Anket";
            SqlCommand komut = new SqlCommand(sorgu, con.baglanti);
            SqlDataReader baslikoku = komut.ExecuteReader();
            tablo.Load(baslikoku);


            cbRanket.DisplayMember = "AnketAd";
            cbRanket.ValueMember = "Id";
            cbRanket.DataSource = tablo;

            con.baglanti.Close();
        }

        private void cbRanket_SelectedValueChanged(object sender, EventArgs e)
        {
            Ranketid =Convert.ToInt32( cbRanket.SelectedValue);
        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            cbturDoldur();
        }
    }
}
