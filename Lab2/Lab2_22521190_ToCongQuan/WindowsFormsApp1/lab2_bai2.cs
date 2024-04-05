using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class flab2 : Form
    {
        public flab2()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab flab  = new flab();
            flab.Show();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            rtbData.Text = sr.ReadToEnd();

            //ten file
            tbTenFile.Text = ofd.SafeFileName.ToString();
            tbUrl.Text = fs.Name.ToString();
            TbSokyTu.Text = rtbData.Text.Length.ToString();
            // dem dong
            string s = rtbData.Text;
            s = s.Replace("\r\n", "\r");
            int linecount = rtbData.Lines.Count();
            tbSoDong.Text = linecount.ToString();
            s = s.Replace("\r", "\r\n");
            // dem tu
            string[] src = s.Split(new char[] {'.','?','!', ';', ':', ',', ' ', '\n'}, StringSplitOptions.RemoveEmptyEntries);
            int wordcount = src.Count();
            tbSoTu.Text = wordcount.ToString();
            fs.Close();
        }
    }
}
