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
    public partial class Frmkanstogu : Form
    {
        public Frmkanstogu()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=ZEYNEP\SQLEXPRESS;Initial Catalog=KANBANKASI;Integrated Security=True");
        private void kanstogu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kANBANKASIDataSet2.KanStok' table. You can move, or remove it, as needed.
            this.kanStokTableAdapter.Fill(this.kANBANKASIDataSet2.KanStok);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
