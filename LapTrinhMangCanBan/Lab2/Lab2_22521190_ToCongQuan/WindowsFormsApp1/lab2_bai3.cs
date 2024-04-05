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
    public partial class flab3 : Form
    {
        public flab3()
        {
            InitializeComponent();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();   
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            using (StreamReader sr = new StreamReader(fs))
            {
                rtbData.Text = sr.ReadToEnd();
               
            }  
            fs.Close();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab t = new flab();
            t.Show();
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.ShowDialog();  

            FileStream fs2 = new FileStream(saveFile.FileName, FileMode.Truncate);
            for(int i = 0;i < rtbData.Text.Length;i++)
            {

                if (rtbData.Text[i] == ',')
                {
                    MessageBox.Show("Số thập phân được ngăn cách bới dấu '.' !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }  
            
           
            using (StreamWriter swt = new StreamWriter(fs2))
            {
                double[] ketqua = new double[rtbData.Lines.Count()];
                for (int z = 0; z < ketqua.Length; z++)
                {
                    ketqua[z] = 0.0d;
                }
                DataTable dt = new DataTable();
                int i = 0;
                foreach(string s in rtbData.Lines)
                {
                    string ex = s.Trim();
                    try
                    {
                        string kq = dt.Compute(ex, "").ToString();
                        ketqua[i] = Math.Round(Convert.ToDouble(kq), 2);
                        i++;
                    }
                    catch ( Exception)
                    {
                        i++;
                    }

                   


                }
                int j = 0;
                foreach(string str in rtbData.Lines)
                {
                    if (ketqua[j] != 0)
                    {
                        swt.Write(str + " = " + ketqua[j].ToString() + "\n");
                    }
                    else
                         swt.Write(str +  "\n") ;
                    j++;
                }
                    
            }    
               
            fs2.Close();
        }
    }
}
