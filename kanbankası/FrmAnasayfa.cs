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
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=ZEYNEP\SQLEXPRESS;Initial Catalog=KANBANKASI;Integrated Security=True");
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            baglantı.Open();
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
            baglantı.Close();
        }

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
           menuStrip1.Enabled = true;
        }

        private void bAĞIŞÇIEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBagıscı fr = new FrmBagıscı();
            fr.Show();
        }

        private void bAĞIŞÇILİSTESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBagıscılistesi fr = new FrmBagıscılistesi();
            fr.Show();
        }

        private void hASTAEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHasta fr = new FrmHasta();
            fr.Show();
        }

        private void hASTALİSTESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHastaListesi fr = new FrmHastaListesi();
            fr.Show();
        }

        private void kANSTOĞUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmkanstogu fr = new Frmkanstogu();
            fr.Show();
        }

        private void dUYURUTABLOSUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yöneticiKontrolPaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYonetici fr = new FrmYonetici();
            fr.Show();
        }

        private void bAĞİŞÇIEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
