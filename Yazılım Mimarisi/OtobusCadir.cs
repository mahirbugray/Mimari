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
    public partial class OtobusCadir : Form
    {
        public OtobusCadir()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        public string tcno;
        public string yer;
        private void OtobusCadir_Load(object sender, EventArgs e)
        {
            lblyer.Text = yer.ToString();
            lbltc.Text = tcno.ToString();

            SqlCommand cmd = new SqlCommand("Select * from Tbl_Musteri where MusteriTC = '"+lbltc.Text+"'",bgl.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                lblad.Text = dr["MusteriAd"].ToString();
                lblsoyad.Text = dr["MusteriSoyad"].ToString();
                lbltelno.Text = dr["TelefonNo"].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
