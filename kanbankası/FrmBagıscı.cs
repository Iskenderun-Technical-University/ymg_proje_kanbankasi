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
    public partial class FrmBagıscı : Form
    {
        public FrmBagıscı()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=ZEYNEP\SQLEXPRESS;Initial Catalog=KANBANKASI;Integrated Security=True");
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmBagıscı_Load(object sender, EventArgs e)
        { 
       
           



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                SqlCommand cmdkaydet = new SqlCommand("INSERT INTO Bagıscı (badsoyad,byas,bcinsiyet,btelefon,badres,bkangrup) VALUES(@P1,@P2,@P3,@P4,@P5,@P6)", baglantı);
                cmdkaydet.Parameters.AddWithValue("@P1", Txtisim.Text);
                cmdkaydet.Parameters.AddWithValue("@P2", TxtYas.Text);
                cmdkaydet.Parameters.AddWithValue("@P3", CmbCinsiyet.Text);
                cmdkaydet.Parameters.AddWithValue("@P4", MskTelefon.Text);
                cmdkaydet.Parameters.AddWithValue("@P5", RchAdres.Text);
                cmdkaydet.Parameters.AddWithValue("@P6", TxtKanGrup.Text);
                cmdkaydet.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Kayıt başarılı!");
               
            }
            catch (Exception ex) {

                MessageBox.Show("Hata,yeniden deneyiniz!");
            }


        }

        private void CmbKanGrubu_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        
        }

        private void TxtKanGrup_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
