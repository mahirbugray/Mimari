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
    public partial class OtobusOtel : Form
    {
        public OtobusOtel()
        {
            InitializeComponent();
        }
        SqlBaglanti bgll = new SqlBaglanti();
        public string tcnosu;
        public string yeri;
        private void OtobusOtel_Load(object sender, EventArgs e)
        {
            lblyer.Text = yeri.ToString();
            lbltc.Text = tcnosu.ToString();

            SqlCommand cmd = new SqlCommand("Select * from Tbl_Musteri where MusteriTC = '" + lbltc.Text + "'", bgll.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblad.Text = dr["MusteriAd"].ToString();
                lblsoyad.Text = dr["MusteriSoyad"].ToString();
                lbltelno.Text = dr["TelefonNo"].ToString();
            }
            bgll.baglanti().Close();
        }
    }
}
