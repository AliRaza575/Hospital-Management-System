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
    public partial class Delete_Salary : Form
    {
        public Delete_Salary()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = guna2DataGridView1.SelectedCells[0].RowIndex;

                // Since SalaryID is in the second column (index 1)
                string salaryId = guna2DataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();

                bool deleted = salaryBL.DeleteSalary(salaryId);

                if (deleted)
                {
                    MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guna2DataGridView1.DataSource = salaryBL.viewsalary(); // Refresh the data grid
                }
                else
                {
                    MessageBox.Show("Salary ID not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Delete_Salary_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = salaryBL.viewsalary();
        }
    }
}
