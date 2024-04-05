using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class flab4 : Form
    {
        public flab4()
        {
            InitializeComponent();
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab f = new flab();
            f.Show();
        }
        public class SinhVien
        {
            public string MSSV;
            public string HoTen;
            public string SDT;
            public float DiemToan = 0f;
            public float DiemVan = 0f;
            public float DTB = 0f;

            public bool check()
            {
                if(MSSV.Length <8)
                    return false;
                if(SDT.Length <10 || SDT.Length >11)
                    return false;
                if(DiemToan < 0.0f || DiemToan > 10.0f || DiemVan < 0.0f || DiemVan > 10.0f) 
                    return false;
                return true;
            }
        }
        List<SinhVien> SV = new List<SinhVien>();

        

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd_out = new OpenFileDialog();
            sfd_out.ShowDialog();
            using (FileStream fs_in = new FileStream(sfd_out.FileName, FileMode.OpenOrCreate))
            {
                BinaryFormatter bf = new BinaryFormatter();
                rtb_output.Text = "";
                fs_in.Position = 0;
                string DSSV = (string)bf.Deserialize(fs_in);
               
                string[] data = DSSV.Split('\n');

                if (data.Length % 5 != 0)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin sinh viên và không thừa hàng trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                try
                {
                    
                   SV.Clear();
                   for(int i = 0; i < data.Length; i=i+5)
                   {
                        SinhVien st = new SinhVien();
                        
                        st.MSSV = data[i]; 
                        st.HoTen = data[i+1]; 
                        st.SDT = data[i+2]; 
                        st.DiemToan = float.Parse(data[i+3]);
                        st.DiemVan = float.Parse(data[i+4]);
                        st.DTB = (st.DiemVan + st.DiemToan) / 2;
                        
                        if (st.check()) 
                        {
                            SV.Add(st);
                        }
                        else
                        {
                            MessageBox.Show("Sinh vien có MSSV: " + st.MSSV + " có dữ liệu sai!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }    
                   }    
                }
                catch(Exception) 
                {
                    MessageBox.Show("Vui lòng nhập đúng cấu trúc thông tin sinh viên!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                foreach (SinhVien sv in SV)
                {
                    rtb_output.Text += sv.MSSV + '\n';
                    rtb_output.Text += sv.HoTen + '\n';
                    rtb_output.Text += sv.SDT + '\n';
                    rtb_output.Text += sv.DiemToan.ToString() + '\n';
                    rtb_output.Text += sv.DiemVan.ToString() + '\n';
                    rtb_output.Text += sv.DTB.ToString() + "\n\n";
                }
            }

            
           
        }

        

        private void btnGhiFileIn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd_in = new SaveFileDialog();
            sfd_in.ShowDialog();
            using (FileStream fs_in = new FileStream(sfd_in.FileName, FileMode.Truncate))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs_in, rtbData.Text);
            }    
               
        }

        private void btGhiFileOut_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd_o = new SaveFileDialog();
            sfd_o.ShowDialog();
            FileStream fs_o = new FileStream(sfd_o.FileName, FileMode.Truncate);
            using (StreamWriter sr = new StreamWriter(fs_o))
            {
                sr.Write(rtb_output.Text);
            }
            fs_o.Close();

        }
    }
}
