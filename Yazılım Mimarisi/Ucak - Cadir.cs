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
using System.Xml;
using System.Xml.Linq;

namespace Yazılım_Mimarisi
{
    public partial class UcakCadir : Form
    {
        public UcakCadir()
        {
            InitializeComponent();
        }
        SqlBaglanti bbg = new SqlBaglanti();
        public string tcnumara;
        public string konum;
        private void Ucak___Cadir_Load(object sender, EventArgs e)
        {
            lblyer.Text = konum.ToString();
            lbltc.Text = tcnumara.ToString();

            SqlCommand cmd = new SqlCommand("Select * from Tbl_Musteri where MusteriTC = '" + lbltc.Text + "'", bbg.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblad.Text = dr["MusteriAd"].ToString();
                lblsoyad.Text = dr["MusteriSoyad"].ToString();
                lbltelno.Text = dr["TelefonNo"].ToString();
            }
            bbg.baglanti().Close();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {

            XDocument xDoc = XDocument.Load(@"rapor.xml");
            //Xml dosyamıza erişip yükleme işlemini gerçekleştiriyoruz.

            XElement rootElement = xDoc.Root;
            //Oluşturduğumuz Root elementine XML dökümanında ki root elementini seçmesini sağlıyoruz.

            XElement newElement = new XElement("rehber");
            //Yeni bir element oluşturuyoruz.

           // XAttribute idAttribute = new XAttribute("id", "4");
            //Elementimize attribute yani Id ataması yapıyoruz.

            XElement adiElement = new XElement("Ad", lblad.Text);
            XElement soyadiElement = new XElement("Soyad", lblsoyad.Text);
            XElement telefonElement = new XElement("Telefon No", lbltelno.Text);
            XElement tcElement = new XElement("TC", lbltc.Text);
            XElement yerElement = new XElement("Yer", lblyer.Text);

            //Elementlerimizin verilerini oluşturmaya devam ediyoruz...

            newElement.Add( adiElement, telefonElement, soyadiElement, tcElement, yerElement);
            //Verilerimizi rehber elementimizin içine sıralı bir şekilde ekliyoruz.

            rootElement.Add(newElement);
            //Oluşturduğumuz yeni elementi root tagının içine ekliyoruz.

            xDoc.Save(@"rapor.xml");
            //Yaptığımız işlemi kayıt ediyoruz.
        }

        private void btnJson_Click(object sender, EventArgs e)
        {

        }

        private void btnHtml_Click(object sender, EventArgs e)
        {

        }
    }
}
