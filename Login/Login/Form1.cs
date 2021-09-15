using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        private bool toggle = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void passimg_Click(object sender, EventArgs e)
        {
            if (toggle == true)
            {
                textBox2.UseSystemPasswordChar = false;
                toggle = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                toggle = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Tanzeel" || textBox1.Text == "mtk@gmail.com" && textBox2.Text == "pass")
            {
                Dashboard ds = new Dashboard("com");
                this.Hide();
                ds.Show();
            }
            else if (textBox1.Text == "Admin" || textBox1.Text == "admin@gmail.com" && textBox2.Text == "pass")
            {
                Dashboard ds = new Dashboard("admin");
                this.Hide();
                ds.Show();
            }
            else
            {
                Warnlabel.Visible = true;
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }


    }
}
