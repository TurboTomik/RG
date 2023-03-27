using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Form2 main_form = new Form2();
            this.Hide();
            main_form.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            pn_log.Visible = true;
            guna2Transition1.ShowSync(pn_log);
        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (ToggleSwitch_shw_paswd.Checked)
            {
                TextBox_reg_paswd.PasswordChar = '\0';
            }
            else
            {
                TextBox_reg_paswd.PasswordChar = '•';
            }
        }

        private void Button_log_crtacc_Click(object sender, EventArgs e)
        {
            pn_log.Visible = false;
            guna2Transition1.HideSync(pn_log);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_log_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
