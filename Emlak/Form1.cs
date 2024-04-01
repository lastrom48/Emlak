using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Emlak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            string harfler = "ABC1ÇDE4546F0GĞHIİ0JKLM4N7OÖPR778S5654674684TUÜ547VYZ52abcçdefgğhı9ijklmno9öp5rsş5tuü87vy6z";
            string uret = "";
            for (int i = 0; i < 4; i++)
            {
                uret += harfler[rastgele.Next(harfler.Length)];
            }
            DogrulamaKodu.Text = uret;
        }

        private void GirisBtn_Click(object sender, EventArgs e)
        {
            if (DogrulamaTxt.Text == "")
            {
                MessageBox.Show("lütfen boş geçmeyiniz");
            }
            else if (KullaniciAdiTxt.Text == "admin" && SifreTxt.Text == "1234" && DogrulamaTxt.Text == DogrulamaKodu.Text)
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (GizliGosterchc.CheckState == CheckState.Checked)
            {
                SifreTxt.UseSystemPasswordChar = true;
                GizliGosterchc.Text = "Gizle";
            }
            else if (GizliGosterchc.CheckState == CheckState.Unchecked)
            {
                SifreTxt.UseSystemPasswordChar = false;
                GizliGosterchc.Text = "göster";
            }
        }

        private void DogrulamaLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
