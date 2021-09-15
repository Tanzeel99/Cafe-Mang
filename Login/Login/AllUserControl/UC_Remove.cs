using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login.AllUserControl
{
    public partial class UC_Remove : UserControl
    {
        function fn = new function();
        String query;
        public UC_Remove()
        {
            InitializeComponent();
        }

        private void UC_Remove_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            query = "select * from items";
            DataSet ds=  fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0]; 
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where Item_Name like'" + txtSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Delete item ?","Important Message",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from items where id=" + id + "";
                fn.SetData(query);
                loadData();
            }
        }
    }
}
