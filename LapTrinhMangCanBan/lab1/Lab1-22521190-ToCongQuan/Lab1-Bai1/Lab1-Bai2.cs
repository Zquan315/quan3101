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
    public partial class flab2 : Form
    {
        public flab2()
        {
            InitializeComponent();
        }
        Double Min, Max;
        private void btFind_Click(object sender, EventArgs e)
        {
            for(int i=0;i<tbn1.Text.Length;i++)
            {
                if (tbn1.Text[i] == ',')
                {
                    MessageBox.Show("Xin vui lòng nhập dữ liệu là số!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            for (int i = 0; i < tbn2.Text.Length; i++)
            {
                if (tbn2.Text[i] == ',')
                {
                    MessageBox.Show("Xin vui lòng nhập dữ liệu là số!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            for (int i = 0; i < tbn3.Text.Length; i++)
            {
                if (tbn3.Text[i] == ',')
                {
                    MessageBox.Show("Xin vui lòng nhập dữ liệu là số!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            // xét điều kiện
            Double num = 0.0d;
            
            bool ktra1 = Double.TryParse(tbn1.Text.Trim(), out num);
            bool ktra2 = Double.TryParse(tbn2.Text.Trim(), out num);
            bool ktra3 = Double.TryParse(tbn3.Text.Trim(), out num);
            if (!ktra1 || !ktra2 || !ktra3)
            {
                MessageBox.Show("Xin vui lòng nhập dữ liệu là số!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //tính toán
            double n1 = Convert.ToDouble(tbn1.Text.Trim());
            double n2 = Convert.ToDouble(tbn2.Text.Trim());
            double n3 = Convert.ToDouble(tbn3.Text.Trim());
            Double num1, num2, num3;
            num1 = n1;
            num2 = n2;
            num3 = n3;
            if (num1 >= num2 && num1 >= num3)
                Max = num1;
            else if (num2 >= num1 && num2 >= num3)
                Max = num2;
            else if (num3 >= num1 && num3 >= num2)
                Max = num3;

            if (num1 < num2 && num1 < num3)
                Min = num1;
            else if (num2 < num1 && num2 < num3)
                Min = num2;
            else if (num3 < num1 && num3 < num2)
                Min = num3;
            maxnum.Text = Max.ToString();
            minNum.Text = Min.ToString();

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            tbn1.Text = tbn2.Text = tbn3.Text = maxnum.Text = minNum.Text = "";

        }

        private void btExi_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab flab = new flab();
            flab.ShowDialog();
        }
    }
}
