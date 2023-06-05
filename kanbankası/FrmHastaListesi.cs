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
    public partial class FrmHastaListesi : Form
    {
        public FrmHastaListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=ZEYNEP\SQLEXPRESS;Initial Catalog=KANBANKASI;Integrated Security=True");
        private void HastaListesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kANBANKASIDataSet1.Hasta' table. You can move, or remove it, as needed.
            this.hastaTableAdapter.Fill(this.kANBANKASIDataSet1.Hasta);

        }

        private void BtnBagıscıEkle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Hasta WHERE hid=@P1 ", baglantı);
                cmd.Parameters.AddWithValue("@P1", Txtİd.Text);
                cmd.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Silme işlemi gerçekleşti!");
                this.hastaTableAdapter.Fill(this.kANBANKASIDataSet1.Hasta);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata,yeniden deneyiniz!");
            }
        }
        int secilen;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, hastaadsoyad,yas,telefon,cinsiyet,kangrubu,adres;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            hastaadsoyad= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            yas= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            telefon= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cinsiyet= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            kangrubu= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            adres= dataGridView1.Rows[secilen].Cells[6].Value.ToString();


            Txtİd.Text = id;
            Txtisimsoyisim.Text = hastaadsoyad;
            TxtYas.Text = yas;
            MskTelefon.Text = telefon;
            CmbCinsiyet.Text = cinsiyet;
            TxtKanGrup.Text = kangrubu;
            RchAdres.Text = adres;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                SqlCommand cmd2 = new SqlCommand("UPDATE Hasta SET hadsoyad=@p1,hyas=@p2, htelefon=@p3,hcinsiyet=@p4,hkangrup=@p5,hadres=@p6 WHERE hid=@p7 ", baglantı);
                cmd2.Parameters.AddWithValue("@p7", Txtİd.Text);
                cmd2.Parameters.AddWithValue("@p1", Txtisimsoyisim.Text);
                cmd2.Parameters.AddWithValue("@p2", TxtYas.Text);
                cmd2.Parameters.AddWithValue("@p3", MskTelefon.Text);
                cmd2.Parameters.AddWithValue("@p4", CmbCinsiyet.Text);
                cmd2.Parameters.AddWithValue("@p5", TxtKanGrup.Text);
                cmd2.Parameters.AddWithValue("@p6", RchAdres.Text);
                cmd2.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Güncelleme yapıldı!");
                this.hastaTableAdapter.Fill(this.kANBANKASIDataSet1.Hasta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata,yeniden deneyiniz!");
            }
        }
    }
}
