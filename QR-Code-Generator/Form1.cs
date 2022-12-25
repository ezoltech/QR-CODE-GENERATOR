using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Code_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(txt_url.Text == "")
            {
                MessageBox.Show("Nothing To Generate, please inseert or, paste your url inorder to generate your QR-CODE");
            }
            else
            {
                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(txt_url.Text, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                pic_gen.Image = code.GetGraphic(5);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_url.Text = "";
            pic_gen.Image = null;
        }
    }
}
