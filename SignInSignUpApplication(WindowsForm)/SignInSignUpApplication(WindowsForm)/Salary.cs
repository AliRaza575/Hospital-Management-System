using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Salary : Form
    {
        private string userID;
        private bool flag;

        public Salary()
        {
            InitializeComponent();
            flag = true;
        }
        public Salary(int id)
        {
            InitializeComponent();
            userID = id.ToString(); // assuming MongoDB uses string IDs
            flag = false; // show specific doctor
        }

       

        private void Salary_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();

            //AdminBL.ShowDoctorsQuery();
            //LoadDataIntoDataGridView();
        }


        private void LoadDataIntoDataGridView()
        {
            guna2DataGridView1.DataSource = DoctorBL.ViewDoctor(flag, userID);

        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = guna2DataGridView1.SelectedCells[0].RowIndex;
                string doctorId = guna2DataGridView1.Rows[selectedRowIndex].Cells["DoctorID"].Value.ToString();
                string date=dateTimePicker1.Text;
                int salary = int.Parse(salarytxt.Text);

                salaryBL.AddSalary(doctorId, salary,date);

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = guna2DataGridView1.SelectedCells[0].RowIndex;

                // Since SalaryID is in the second column (index 1)
                string salaryId = guna2DataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString();

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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = salaryBL.viewsalary();
        }

        private void salarytxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
