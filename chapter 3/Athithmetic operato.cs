sing System;
using System.Windows.Forms;

namespace chapter_3
{
    public partial class Form1 : Form
    {
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtNum1.Text);
            int b = Convert.ToInt32(txtNum2.Text);
            lblResult.Text = "Result: " + (a + b);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtNum1.Text);
            int b = Convert.ToInt32(txtNum2.Text);
            lblResult.Text = "Result: " + (a - b);
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtNum1.Text);
            int b = Convert.ToInt32(txtNum2.Text);
            lblResult.Text = "Result: " + (a * b);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtNum1.Text);
            int b = Convert.ToInt32(txtNum2.Text);

            if (b != 0)
                lblResult.Text = "Result: " + (a / b);
            else
                lblResult.Text = "Cannot divide by zero!";
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtNum1.Text);
            int b = Convert.ToInt32(txtNum2.Text);
            lblResult.Text = "Result: " + (a % b);
        }
    }
}