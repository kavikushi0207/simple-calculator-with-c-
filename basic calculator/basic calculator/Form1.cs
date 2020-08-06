using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace basic_calculator
{
    public partial class simpleCalculator : Form
    {
        public simpleCalculator()
        {
            InitializeComponent();
        }

        float ans, num;
        int count;
        bool keyStart ;
        public void dotRepeat()
        {
            string number = txtAns.Text;
            int count1 = 0;
            for (int i = 0; i < number.Length-1; i++)
            {
                if (number[i].Equals("."))
                {
                    count1 ++;
                }

            }
            if (count1 >= 2)
            {
                MessageBox.Show("syntax error");
                txtAns.Clear();
            }
        }

        public void disable()
        {
            btnOff.Hide();
            btnONN.Show();
            txtAns.Clear();
            txtAns.Enabled = false;
            btnmulti.Enabled = false;
            btnsub.Enabled = false;
            btnadd.Enabled = false;
            btndivide.Enabled = false;
            btnCE.Enabled = false;
            btnBack.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btn0.Enabled = false;
            btnequal.Enabled = false;
            btnDot.Enabled = false;
        }

        public void enable()
        {
            btnOff.Show();
            btnONN.Hide();
            txtAns.Clear();
            txtAns.Enabled = true;
            btnmulti.Enabled = true;
            btnsub.Enabled = true;
            btnadd.Enabled = true;
            btndivide.Enabled = true;
            btnCE.Enabled = true;
            btnBack.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn0.Enabled = true;
            btnequal.Enabled = true;
            btnDot.Enabled = true;
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            
            if (keyStart == true)
            {
                txtAns.Clear();

            }
            txtAns.Text = txtAns.Text + "0";
            keyStart = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            if (keyStart == true)
            {
                txtAns.Clear();

            }

            txtAns.Text = txtAns.Text + "1";
            keyStart = false;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtAns.Text = "";
            lblEquation.Text = "";
        }

       
        private void btnDot_Click(object sender, EventArgs e)
        {
           
            if (keyStart == true)
            {
                txtAns.Clear();

            }
            txtAns.Text = txtAns.Text + ".";
            if (txtAns.Text.StartsWith(".") || txtAns.Text.Contains("..") )
            {
                MessageBox.Show("syntax error");
                txtAns.Clear();
            }
            dotRepeat();
            

            keyStart = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //keyStart = false;
            if (keyStart == true)
            {
                txtAns.Clear();

            }
            txtAns.Text = txtAns.Text + "4";
            keyStart = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //keyStart = false;
            if (keyStart == true)
            {
                txtAns.Clear();

            }
            txtAns.Text = txtAns.Text + "5";
            keyStart = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //keyStart = false;
            if (keyStart == true)
            {
                txtAns.Clear();

            }
            txtAns.Text = txtAns.Text + "6";
            keyStart = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //keyStart = false;
            if (keyStart == true)
            {
                txtAns.Clear();

            }
            txtAns.Text = txtAns.Text + "7";
            keyStart = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //keyStart = false;
            if (keyStart == false)
            {
                txtAns.Clear();

            }
            txtAns.Text = txtAns.Text + "8";
            keyStart = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //keyStart = false;
            if (keyStart == true)
            {
                txtAns.Clear();

            }
            txtAns.Text = txtAns.Text + "9";
            keyStart = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //keyStart = false;
            if (keyStart == true)
            {
                txtAns.Clear();

            }
            txtAns.Text = txtAns.Text + "3";
            keyStart = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //keyStart = false;
            if (keyStart == true)
            {
                txtAns.Clear();

            }
            txtAns.Text = txtAns.Text + "2";
            keyStart = false;
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void btnONN_Click(object sender, EventArgs e)
        {
            enable();
        }

        public void operations()
        {
            switch (count)
            {
                case 1:
                    ans = num + float.Parse(txtAns.Text);
                    txtAns.Text = ans.ToString();
                    break;
                case 2:
                    ans = num - float.Parse(txtAns.Text);
                    txtAns.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(txtAns.Text);
                    txtAns.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(txtAns.Text);
                    txtAns.Text = ans.ToString();
                    break;
                default :
                    break;
            }

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            dotRepeat();
            num = float.Parse(txtAns.Text);
            txtAns.Clear();
            txtAns.Focus();
            count = 1;
            lblEquation.Text = num.ToString() + "+";
            
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            dotRepeat();
            num = float.Parse(txtAns.Text);
            txtAns.Clear();
            txtAns.Focus();
            count = 2;
            lblEquation.Text = num.ToString() + "-";
            
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            dotRepeat();
            num = float.Parse(txtAns.Text);
            txtAns.Clear();
            txtAns.Focus();
            count = 3;
            lblEquation.Text = num.ToString() + "x";
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            dotRepeat();
            num = float.Parse(txtAns.Text);
            txtAns.Clear();
            txtAns.Focus();
            count = 4;
            lblEquation.Text = num.ToString() + "/";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            dotRepeat();
            operations();
            
            lblEquation.Text = "";
            keyStart = true;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int length = txtAns.TextLength - 1;
            string text = txtAns.Text;
            txtAns.Clear();
            for (int i = 0; i < length;i++ ) {
                txtAns.Text = txtAns.Text + text[i];
            }


        }

       /* private void btnequal_TabIndexChanged(object sender, EventArgs e)
        {
            txtAns.Clear();
        }*/


        
       

        

        


       

      

        
    }
}
