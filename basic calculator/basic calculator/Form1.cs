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
            txtAns.Text = txtAns.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtAns.Text = txtAns.Text + "1";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtAns.Text = "";
        }

       
        private void btnDot_Click(object sender, EventArgs e)
        {
            txtAns.Text = txtAns.Text + ".";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtAns.Text = txtAns.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtAns.Text = txtAns.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtAns.Text = txtAns.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtAns.Text = txtAns.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtAns.Text = txtAns.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtAns.Text = txtAns.Text + "9";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtAns.Text = txtAns.Text + "3";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtAns.Text = txtAns.Text + "2";
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void btnONN_Click(object sender, EventArgs e)
        {
            enable();
        }

       

      

        
    }
}
