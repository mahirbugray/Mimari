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
    public partial class Giris_Yap : Form
    {
        public Giris_Yap()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Musteri where MusteriTC=@p1 and MusteriSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtboxtc.Text);
            komut.Parameters.AddWithValue("@p2", txtboxsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                RezervasyonSecim frm = new RezervasyonSecim();
                frm.tc = Convert.ToString( txtboxtc.Text);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya şifre");
            }
            bgl.baglanti().Close();
        }
    }
    
}
