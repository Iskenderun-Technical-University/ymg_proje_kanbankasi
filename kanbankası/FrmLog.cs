using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kanbankası
{
    public partial class FrmLog : Form
    {
        public FrmLog()
        {
            InitializeComponent();
        }

        private void BtnGırıs_Click(object sender, EventArgs e)
        {
            if(TxtKullanıcıAdı.Text=="admin31" && TxtSıfre.Text=="7777")
            {
                FrmAnasayfa fr = new FrmAnasayfa();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız!");
            }
        }
    }
}
