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
    public partial class UcakOtel : Form
    {
        public UcakOtel()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl1 = new SqlBaglanti();
        public string tcsi;
        public string yerkonum;
        private void UcakOtel_Load(object sender, EventArgs e)
        {
            lblyer.Text = yerkonum.ToString();
            lbltc.Text = tcsi.ToString();

            SqlCommand cmd = new SqlCommand("Select * from Tbl_Musteri where MusteriTC = '" + lbltc.Text + "'", bgl1.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblad.Text = dr["MusteriAd"].ToString();
                lblsoyad.Text = dr["MusteriSoyad"].ToString();
                lbltelno.Text = dr["TelefonNo"].ToString();
            }
            bgl1.baglanti().Close();
        }
    }
}
