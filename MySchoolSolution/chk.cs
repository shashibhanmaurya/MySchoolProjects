using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySchoolSolution
{
    public partial class chk : Form
    {
        public chk()
        {
            InitializeComponent();
        }

        private void chk_Load(object sender, EventArgs e)
        {
            SqlParameter[] m = new SqlParameter[1];
            m[0] = new SqlParameter("@Session", CommonFunctions.GetCurrentSession);
            SqlDataReader dr = SqlHelper.ExecuteReader(Connection.Connection_string, "StudentInfoAutoComplete", m);
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                MyCollection.Add(dr.GetString(0));
            }
            txtStudent.AutoCompleteMode = AutoCompleteMode.Suggest;

            txtStudent.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtStudent.AutoCompleteCustomSource = MyCollection;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrCode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrCode.Draw(txtStudent.Text, 50);
            MessagingToolkit.QRCode.Codec.QRCodeDecoder d = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
            textBox1.Text = d.Decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap));
        }
    }
}
