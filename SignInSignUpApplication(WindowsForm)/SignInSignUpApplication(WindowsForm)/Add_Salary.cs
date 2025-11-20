using Guna.UI2.AnimatorNS;
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
    public partial class Add_Salary : Form
    {
        private string userID;
        private bool flag;

        public Add_Salary()
        {
            InitializeComponent();
            flag = true;
        }

        public Add_Salary(int id)
        {
            InitializeComponent();
            
            userID = id.ToString(); // assuming MongoDB uses string IDs
            flag = false; // show specific doctor
        }


        private void LoadDataIntoDataGridView()
        {
            guna2DataGridView1.DataSource = DoctorBL.ViewDoctor(flag, userID);

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = guna2DataGridView1.SelectedCells[0].RowIndex;
                string doctorId = guna2DataGridView1.Rows[selectedRowIndex].Cells["DoctorID"].Value.ToString();
                string date = dateTimePicker1.Text;
                int salary = int.Parse(salarytxt.Text);

                salaryBL.AddSalary(doctorId, salary, date);

            }
        }

        private void Add_Salary_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }
    }
}
