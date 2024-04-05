using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Bai1
{
    public partial class flab3 : Form
    {
        public flab3()
        {
            InitializeComponent();
        }

        private void btDoc_Click(object sender, EventArgs e)
        {
            int num = 0;
            int n = input.Text.Length;
            int number = Convert.ToInt32(input.Text.Trim());
            bool b = Int32.TryParse(input.Text.Trim(), out num);
            if (!b || number < 0)
            {
                MessageBox.Show("Vui lòng nhập dữ liệu là số nguyên dương!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if(number > 10000) 
            {
                MessageBox.Show("Vui lòng nhập dữ liệu trong khoảng giá trị!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string[] So = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín", "mười" };
            string[] donvi = { "nghìn", "trăm"};
            string[] spec = { "mươi", "lăm", "lẻ"};
            if(number <= 10)
            {
                label1.Text = So[number];
            }    
            else if(number> 10 && number < 20)
            {
                int a = number / 10;
                int sodu = number % 10;
                a = number - sodu;
                if (number == 15)
                    label1.Text = So[a] + " "+ spec[1];
                else               
                    label1.Text = So[a] + " "+ So[sodu];
               
            }
            else if(number >=20 && number <100)
            {
                if(number % 10 == 0)
                {
                    int a = number / 10;
                    label1.Text = So[a] + " "+ spec[0];
                }
                else
                {
                    int a1 = number / 10;
                    int a2 = number % 10;
                    if ((number % 10) == 5)
                        label1.Text = So[a1] + " " + spec[0] + " " + spec[1];
                    else 
                        label1.Text = So[a1] + " " + spec[0] + " " + So[a2];
                } 
                
            }    
            else if(number >= 100 && number < 1000)
            { 
                if(number % 100 == 0)
                {
                    int m = number / 100;
                    label1.Text = So[m] + " "+ donvi[1];
                }
                else
                {
                   
                        
                    int[] arr = new int[3];
                    int number2 = number;
                    int i = 2;
                    while (i >= 0)
                    {
                        int a1 = number % 10;
                        arr[i] = a1;
                        number -= a1;
                        number /= 10;
                        i--;
                    }
                    int sodu = number2 % 10;
                    if (sodu > 0 && sodu <= 10 && arr[1] == 0)
                    {
                        label1.Text = So[arr[0]] + " " + donvi[1] + " " + spec[2] + " " + So[sodu];
                        return;
                    }
                    if (arr[1] == 1)
                    {
                       string text = So[arr[0]] + " " + donvi[1] + " " + So[10]+ " ";
                        if (arr[2] == 5)
                            label1.Text = text + spec[1];
                        else if (arr[2]==0)
                            label1.Text = text ;
                        else 
                            label1.Text = text + So[arr[2]];
                        return;
                    }     
                    string t = So[arr[0]] + " " + donvi[1] + " " + So[arr[1]] + " " + spec[0];
                    if (arr[2] == 0)
                        label1.Text = t;
                    else if (arr[2] == 5)
                        label1.Text = t +  " " +spec[1];
                    else 
                        label1.Text = t + " " + So[arr[2]];
                }
                
            }  
            else if(number >= 1000 && number <= 10000)
            {
                if (number % 1000 == 0)
                {
                    int m = number / 1000;
                    label1.Text = So[m] + " " + donvi[0];
                }
                else
                {
                    int sodu = number %  10;
                    int sodu2 = number % 100;    
                    int[] arr = new int[4];
                    int i = 3;
                    while (i >= 0)
                    {
                        int a1 = number % 10;
                        arr[i] = a1;
                        number -= a1;
                        number /= 10;
                        i--;
                    }
                    if (arr[2] == 0 && arr[3] == 0)
                    {
                        string ch = So[arr[0]] + " " + donvi[0] + " " + So[arr[1]] + " " + donvi[1] ;
                        label1.Text = ch;
                        return;
                    }
                    if (arr[2] == 0 )
                    {
                        string ch = So[arr[0]] + " " + donvi[0] + " " + So[arr[1]] + " " + donvi[1] + " " + "lẻ" + " " + So[sodu];
                        label1.Text = ch;
                        return;
                    }
                    string t;
                    if (sodu2 >=10 && sodu2 <20)
                        t = So[arr[0]] + " " + donvi[0] + " " + So[arr[1]] + " " + donvi[1] + " " + So[10] ;
                    else 
                        t = So[arr[0]] + " " + donvi[0] + " " + So[arr[1]] + " " + donvi[1] + " " + So[arr[2]] + " " + spec[0];
                    if (arr[3] == 0)
                        label1.Text = t;
                    else if (arr[3] == 5)
                        label1.Text = t + " " + spec[1];
                    else
                        label1.Text = t + " " + So[arr[3]];
                }
            }    
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            flab f = new flab();
            f.ShowDialog();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            input.Text = label1.Text = "";
            
        }
    }
}