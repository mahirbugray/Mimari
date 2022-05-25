using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılım_Mimarisi
{
    public partial class RezervasyonSecim : Form
    {
        public RezervasyonSecim()
        {
            InitializeComponent();
        }
        public string tc;
        public string lokasyon;
        
        private void RezervasyonSecim_Load(object sender, EventArgs e)
        {
            label4.Text = tc.ToString();
        }
        
        private void btn_Otobus_Cadir_Click(object sender, EventArgs e)
        {
            lokasyon = Convert.ToString(comboBox1.Text);
            OtobusCadir fr = new OtobusCadir();
            fr.yer = lokasyon;
            fr.tcno = label4.Text;
            
            fr.Show();
        }

        private void btn_Otobus_Otel_Click(object sender, EventArgs e)
        {
            lokasyon = Convert.ToString(comboBox1.Text);
            OtobusOtel frm = new OtobusOtel();
            frm.tcnosu = label4.Text;
            frm.yeri= lokasyon;
            frm.Show();
        }

        private void btn_Ucak_Cadir_Click(object sender, EventArgs e)
        {
            lokasyon = Convert.ToString(comboBox1.Text);
            UcakCadir frr = new UcakCadir();
            frr.tcnumara = label4.Text;
            frr.konum = lokasyon;
            frr.Show();

        }

        private void btn_Ucak_Otel_Click(object sender, EventArgs e)
        {
            lokasyon = Convert.ToString(comboBox1.Text);
            UcakOtel frr2 = new UcakOtel();
            frr2.tcsi = label4.Text;
            frr2.yerkonum = lokasyon;
            frr2.Show();
        }
    }
}
