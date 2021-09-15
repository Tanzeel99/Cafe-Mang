using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(String user)
        {
            InitializeComponent();
            if(user=="com")
            {
                button2.Hide();
                button3.Hide();
                button4.Hide();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            uC_PlaceOrder2.Visible = true;
            uC_PlaceOrder2.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = true;
            uC_AddItems1.BringToFront();
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = false;
            uC_PlaceOrder2.Visible = false;
            uC_Update1.Visible = false;
            uC_Remove1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            uC_Welcome1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uC_Update1.Visible = true;
            uC_Update1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            uC_Remove1.Visible = true;
            uC_Remove1.BringToFront();
        }

        private void btnlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }
    }
}
