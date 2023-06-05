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

namespace kanbankası
{
    public partial class FrmHasta : Form
    {
        public FrmHasta()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=ZEYNEP\SQLEXPRESS;Initial Catalog=KANBANKASI;Integrated Security=True");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MskTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FrmHasta_Load(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                SqlCommand cmdkaydet = new SqlCommand("INSERT INTO Hasta (hadsoyad,hyas,htelefon,hcinsiyet,hkangrup,hadres) VALUES(@K1,@K2,@K3,@K4,@K5,@K6)", baglantı);
                cmdkaydet.Parameters.AddWithValue("@K1", Txtisimsoyisim.Text);
                cmdkaydet.Parameters.AddWithValue("@K2", TxtYas.Text);
                cmdkaydet.Parameters.AddWithValue("@K3", MskTelefon.Text);
                cmdkaydet.Parameters.AddWithValue("@K4", CmbCinsiyet.Text);
                cmdkaydet.Parameters.AddWithValue("@K5", TxtKanGrup.Text);
                cmdkaydet.Parameters.AddWithValue("@K6", RchAdres.Text);
                cmdkaydet.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Kayıt başarılı!");

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            {
                baglantı.Close();
            }
        }

        private void Txtsoyisim_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CmbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSıl_Click(object sender, EventArgs e)
        {

        }
    }
}
