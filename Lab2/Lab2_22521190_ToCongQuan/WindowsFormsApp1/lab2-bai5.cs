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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class flab5 : Form
    {
        public flab5()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab f = new flab();
            f.Show();
        }

        private void btDuyet_Click(object sender, EventArgs e)
        {
            
            string path = @tbPath.Text;
            if (!Directory.Exists(path))
            {
                MessageBox.Show("Thư mục không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lvData.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] fi = di.GetFiles();
            foreach (FileInfo f in fi) 
            {
               ListViewItem item = new ListViewItem(f.Name);
               item.SubItems.Add(f.Length.ToString());
               item.SubItems.Add(f.Extension);
               item.SubItems.Add(f.CreationTime.ToString());
               lvData.Items.Add(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
