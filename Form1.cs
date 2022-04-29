using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace App24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            DirectoryInfo dr = new DirectoryInfo(@"E:\Test");
            FileInfo[] arquivos = dr.GetFiles("*");
            foreach (FileInfo arquivo in arquivos)
            {
                comboBox1.Items.Add(arquivo);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBox1.Text;
            pictureLogo.Image = Image.FromFile(s);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
