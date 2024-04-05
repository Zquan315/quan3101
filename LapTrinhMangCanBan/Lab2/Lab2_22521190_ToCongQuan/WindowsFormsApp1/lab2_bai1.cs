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


namespace WindowsFormsApp1
{
    public partial class flab1 : Form
    {
        public flab1()
        {
            InitializeComponent();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            rtbData.Text = sr.ReadToEnd();
            fs.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab flab = new flab();
            flab.Show();
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fsw = new FileStream(sfd.FileName, FileMode.Truncate);
            using (StreamWriter sw = new StreamWriter(fsw))
                sw.Write(rtbData.Text.ToUpper());
            fsw.Close();
        }
    }
}
