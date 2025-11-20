using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSignUpApplication_WindowsForm_
{
    public partial class Delete_Bill : Form
    {
        public Delete_Bill()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Bill_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = BillBL.ViewBill();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = guna2DataGridView1.SelectedCells[0].RowIndex;

                // BillID is in the first column (index 0)
                string billId = guna2DataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();

                bool deleted = BillBL.DeleteBill(billId);

                if (deleted)
                {
                    MessageBox.Show("Bill deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guna2DataGridView1.DataSource = BillBL.ViewBill(); // Refresh the DataGrid
                }
                else
                {
                    MessageBox.Show("Bill ID not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
