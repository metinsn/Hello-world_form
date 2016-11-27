using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_world_form
{
    public partial class ilkForm : Form
    {
        public ilkForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Merhaba Dünya");
        }

        private void BtnMesage1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ad Soyad \t:" + AdSoyadTxtBox.Text + "\n" + "Şifre \t:" + SifreTxtBox.Text);
        }

        private void SifreTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
