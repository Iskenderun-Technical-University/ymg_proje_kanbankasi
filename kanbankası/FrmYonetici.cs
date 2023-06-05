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
    public partial class FrmYonetici : Form
    {
        public FrmYonetici()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=ZEYNEP\SQLEXPRESS;Initial Catalog=KANBANKASI;Integrated Security=True");
        private void FrmYonetici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kANBANKASIDataSet11.Kullanıcı' table. You can move, or remove it, as needed.
            this.kullanıcıTableAdapter.Fill(this.kANBANKASIDataSet11.Kullanıcı);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand cmd3 = new SqlCommand("UPDATE Kullanıcı SET kullanıcı=@c1, kullanıcısifre=@c2 WHERE yoneticiid=@c3",baglantı);
            cmd3.Parameters.AddWithValue("@c1",TxtKullanıcıAdı.Text);
            cmd3.Parameters.AddWithValue("@c2",TxtSıfre.Text);
            cmd3.Parameters.AddWithValue("@c3",TxtId.Text);
            cmd3.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Yönetici güncellendi!");
            this.kullanıcıTableAdapter.Fill(this.kANBANKASIDataSet11.Kullanıcı);

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Kullanıcı (kullanıcı,kullanıcısifre) VALUES (@p1,@p2)",baglantı);
            cmd.Parameters.AddWithValue("@p1",TxtKullanıcıAdı.Text);
            cmd.Parameters.AddWithValue("@p2",TxtSıfre.Text);
            cmd.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Yönetici eklendi!");
            this.kullanıcıTableAdapter.Fill(this.kANBANKASIDataSet11.Kullanıcı);



        }

        private void BtnSıl_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand cmd2 = new SqlCommand("DELETE FROM  Kullanıcı WHERE yoneticiid=@K1", baglantı) ;
            cmd2.Parameters.AddWithValue("@K1",TxtId.Text);
            cmd2.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Yönetici silindi!");
            this.kullanıcıTableAdapter.Fill(this.kANBANKASIDataSet11.Kullanıcı);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, sifre, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();


            TxtId.Text =id;
            TxtKullanıcıAdı.Text = ad;
            TxtSıfre.Text = sifre;
        }
    }
}
