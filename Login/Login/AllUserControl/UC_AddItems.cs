using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login.AllUserControl
{
    public partial class UC_AddItems : UserControl
    {
        function fn = new function();
        string query;
        public UC_AddItems()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query = "insert into items(item_name,category,price)values('"+textBox1.Text+"','"+comboBox1.Text+"',"+textBox2.Text+")";
            fn.SetData(query);
            clearAll();
        }
        public void clearAll()
        {
            comboBox1.SelectedIndex = -1;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void UC_AddItems_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
