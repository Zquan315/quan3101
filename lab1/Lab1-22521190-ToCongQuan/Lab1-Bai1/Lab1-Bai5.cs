using System;
using System.CodeDom;
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
            f.ShowDialog();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            inputDS.Text = tbinh.Text = hocluc.Text = max.Text = min.Text = SoMonDau.Text = SoMonRot.Text = "";
            mon1.Text = mon2.Text = mon3.Text = mon4.Text = mon5.Text = mon6.Text = mon7.Text = mon8.Text = mon9.Text = mon10.Text = mon11.Text = mon12.Text = "";
        }

        private void btXuat_Click(object sender, EventArgs e)
        {
            
            string t = inputDS.Text.Trim();
            if(t.Length == 0)
            {
                MessageBox.Show("Dữ liệu rỗng!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            } 
                
            for (int i = 0; i < t.Length - 1; i++)
            {
               
                if ((t[i] == ' ' && t[i + 1] == ' ') )
                {
                   string ss=  t.Substring(0,i) + t.Substring(i+1) ;
                    t = ss;
                    --i;
                }    
                    
            }

            
            double num = 0.0d;
            string[] arr = t.Split(' ');
            for(int i=0; i<arr.Length; i++)
            {
                if (!double.TryParse(arr[i], out num))
                {
                    MessageBox.Show("Điểm phải là số nguyên hoặc số thực!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }    
            }    
            //for (int i = 0; i <= t.Length - 1; i++)
            //{
            //    if (t[i] == ' ' || t[i] == '.')
            //        continue;
            //    else if ((t[i] >= 'a' && t[i] <= 'z') || (t[i] >= 'A' && t[i] <= 'Z'))
            //    {
            //        MessageBox.Show("Điểm phải là số nguyên hoặc số thực!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        return;
            //    }
            //}
            
            if(arr.Length > 12 )
            {
                MessageBox.Show("Số lượng điểm phải nhỏ hơn hoặc bằng 12 !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            double[] a = new double[arr.Length];

            Label[] l = [mon1, mon2, mon3, mon4, mon5, mon6, mon7, mon8, mon9, mon10, mon11, mon12];


            int j = 0;
            foreach (string c in arr)
            {

                double k = Convert.ToDouble(c);
                if (k < 0.0d || k > 10.0d)
                {
                    MessageBox.Show("Điểm phải có giá trị từ 0 đến 10!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                a[j] = k;
                j++;
            }
            for (int i = 0;i < l.Length;i++)
            {
                l[i].Text = "";
            }
            for(int i = 0; i < a.Length ; i++)
            {
                l[i].Text = a[i].ToString() + " đ";
            }
            
            

            tbinh.Text = Math.Round(a.Average(),2).ToString() ;

            // học lực
            int flagG, flagK, flagTB, flagY;
            flagG = flagK = flagTB = flagY  = 1;
            for (int g =0; g < a.Length;g++)
            {
                if (a[g] < 6.5)               
                    flagG = 0;
                if (a[g] < 5)
                    flagK = 0;
                if (a[g] < 3.5)
                    flagTB = 0;
                if (a[g] < 2)
                    flagY = 0;
            }
            

            if (Convert.ToDouble(tbinh.Text) >= 8 && flagG == 1)
                hocluc.Text = "Giỏi";
            else if (Convert.ToDouble(tbinh.Text) >= 6.5 && flagK == 1)
                hocluc.Text = "Khá";
            else if (Convert.ToDouble(tbinh.Text) >= 5 && flagTB == 1)
                hocluc.Text = "Trung bình";
            else if (Convert.ToDouble(tbinh.Text) >= 3.5 && flagY == 1)
                hocluc.Text = "Yếu";
            else 
                hocluc.Text = "Kém";


            max.Text = a.Max().ToString() + " đ";
            min.Text = a.Min().ToString() + " đ";
            int dau =0, rot;
            for (int k = 0; k < a.Length; k++)
                if (a[k] >= 5)
                    dau++;
            rot = a.Length - dau;
            SoMonDau.Text = dau.ToString();
            SoMonRot.Text = rot.ToString();
        }
    }
}
