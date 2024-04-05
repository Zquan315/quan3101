using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Bai1
{
    public partial class flab4 : Form
    {
        public flab4()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab f = new flab();
            f.ShowDialog();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            tbIn.Text = cbb1.Text = cbb2.Text = kq.Text = "";
        }

        private void btThucHien_Click(object sender, EventArgs e)
        {
            string bi = "Binary";
            string hex = "HexaDecimal";
            string dec = "Decimal";

            // chuyển từ binary sang hai cái còn lại
            if (cbb1.Text.Trim() == bi)
            {
                string s = tbIn.Text.Trim();

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '1' || s[i] == '0')
                        continue;
                    else
                    {
                        MessageBox.Show("Dữ liệu sai", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // chuyển sang decimal
                int kqua10 = Convert.ToInt32(s, 2);
                if (cbb2.Text.Trim() == bi)
                    kq.Text = tbIn.Text;
                else if (cbb2.Text.Trim() == dec)
                {
                    kq.Text = kqua10.ToString();
                }
                else if (cbb2.Text == hex)
                {
                   string kqua16 = Convert.ToString(kqua10, 16);
                    kq.Text = kqua16;
                }
            }

            else if(cbb1.Text.Trim() == dec)
            {
                string s = tbIn.Text.Trim();
                int num = 0;
                if(!int.TryParse(s, out num))
                {
                    MessageBox.Show("Dữ liệu sai", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int kqua10 = int.Parse(s);
                if (cbb2.Text == dec)
                {
                    kq.Text = tbIn.Text;
                }
                else if(cbb2.Text == bi)
                {
                    string kqua2 = Convert.ToString(kqua10, 2);
                    kq.Text = kqua2;
                }    
                else if(cbb2.Text == hex)
                {
                    string kqua16 = Convert.ToString(kqua10, 16);
                    kq.Text = kqua16;
                }    
            }  
            else if(cbb1.Text == hex)
            {
                string s = tbIn.Text.Trim().ToLower();
                int num = 0;
                for (int i=0; i< s.Length;i++)
                {
                    if (int.TryParse(s, out num) || s[i] >= 'a' || s[i] <= 'f') continue;
                    else 
                    {  
                        
                        MessageBox.Show("Dữ liệu sai", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }    
                }
                
                int kqua10 = Convert.ToInt32(s, 16);
                if (cbb2.Text == hex)
                    kq.Text= tbIn.Text;
                else if(cbb2.Text == dec)
                {
                   kq.Text = kqua10.ToString();
                }
                else
                {
                    string kqua2 = Convert.ToString(kqua10, 2);
                    kq.Text = kqua2;
                } 
                    
            }    
        }
    }
}
