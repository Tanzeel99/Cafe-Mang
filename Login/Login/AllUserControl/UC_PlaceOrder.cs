using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login.AllUserControl
{
    public partial class UC_PlaceOrder : UserControl
    {
        function fn = new function();
        String query;
        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String category = comboBox1.Text;
            query = "select Item_name from items where category='" + category + "'";
            DataSet ds = fn.getData(query);
            int i;
            for (i = 0; i < ds.Tables[0].Rows.Count; i++) 
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String category = comboBox1.Text;
            query = "select Item_name from items where category='" + category + "' and Item_name like'"+txtSearch.Text+"%'";
            DataSet ds = fn.getData(query);
            int i;
            for (i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuant.ResetText();
            txtTotal.Clear();
            String text = listBox1.GetItemText(listBox1.SelectedItem);
            txtName.Text = text;
            query = "select Price from items where Item_Name='"+text+"'";
            DataSet ds = fn.getData(query);
            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
            
        }

        private void txtQuant_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtQuant.Value.ToString());
            Int64 price = Int64.Parse(txtPrice.Text);
            txtTotal.Text = (quan * price).ToString();
        }

        protected int n, total = 0;
        int amount;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
            catch { }
            total = total - amount;
            lblTotal.Text = "Rs. " + total;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = txtName.Text;
                dataGridView1.Rows[n].Cells[1].Value = txtPrice.Text;
                dataGridView1.Rows[n].Cells[2].Value = txtQuant.Value;
                dataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;
                total = total + int.Parse(txtTotal.Text);
                lblTotal.Text = "Rs." + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
