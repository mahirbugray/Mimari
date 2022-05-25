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

namespace Yazılım_Mimarisi
{
    public partial class Kayıt_Ol : Form
    {
        public Kayıt_Ol()
        {
            InitializeComponent();
            txtSifre.Text = "";
            txtSifre.PasswordChar = '*';
            txtSifre.MaxLength = 4;
        }

       SqlBaglanti _baglanti=new SqlBaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Musteri (MusteriAd,MusteriSoyad,MusteriTC,TelefonNo,MusteriSifre) values (@p1,@p2,@p3,@p4,@p5)",_baglanti.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", mskdTc.Text);
            cmd.Parameters.AddWithValue("@p4", mskdTelNo.Text);
            cmd.Parameters.AddWithValue("@p5", txtSifre.Text);
            cmd.ExecuteNonQuery();
            _baglanti.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir Şifreniz: " + txtSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
