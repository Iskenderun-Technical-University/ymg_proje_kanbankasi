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
namespace kanbankası
{
    public partial class FrmBagıscılistesi : Form
    {
        public FrmBagıscılistesi()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=ZEYNEP\SQLEXPRESS;Initial Catalog=KANBANKASI;Integrated Security=True");
        private void Bagıscılistesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kANBANKASIDataSet.Bagıscı' table. You can move, or remove it, as needed.
            this.bagıscıTableAdapter.Fill(this.kANBANKASIDataSet.Bagıscı);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Bagıscı WHERE bid=@P1 ", baglantı);
                cmd.Parameters.AddWithValue("@P1", TxtId.Text);
                cmd.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Silme işlemi gerçekleşti!");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata,yeniden deneyiniz!");
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                SqlCommand cmd2 = new SqlCommand("UPDATE Bagıscı SET badsoyad=@p1,byas=@p2, btelefon=@p3,bcinsiyet=@p4,bkangrup=@p5,badres=@p6 WHERE bid=@p7 ", baglantı);
                cmd2.Parameters.AddWithValue("@p7", TxtId.Text);
                cmd2.Parameters.AddWithValue("@p1", Txtisimsoyisim.Text);
                cmd2.Parameters.AddWithValue("@p2", TxtYas.Text);
                cmd2.Parameters.AddWithValue("@p3", MskTelefon.Text);
                cmd2.Parameters.AddWithValue("@p4", CmbCinsiyet.Text);
                cmd2.Parameters.AddWithValue("@p5", TxtKanGrup.Text);
                cmd2.Parameters.AddWithValue("@p6", RchAdres.Text);
                cmd2.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Güncelleme yapıldı!");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int secilen;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bagıscıadsoyad, yas, telefon, cinsiyet, kangrubu, adres;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bagıscıadsoyad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            yas = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            telefon = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cinsiyet = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            kangrubu = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            adres = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            TxtId.Text = id;
            Txtisimsoyisim.Text = bagıscıadsoyad;
            TxtYas.Text = yas;
            MskTelefon.Text = telefon;
            CmbCinsiyet.Text = cinsiyet;
            TxtKanGrup.Text = kangrubu;
            RchAdres.Text = adres;



        }
    }
}
