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
    public partial class PatAppointment : Form
    {
        string userid;
        public PatAppointment(string id)
        {
            InitializeComponent();
            this.userid = id;
        }

        private void PatAppointment_Load(object sender, EventArgs e)
        {
         //   PatientBL.LoadDoctors();
            LoadDataIntoDataGridView();
        }
        private void LoadDataIntoDataGridView()
        {
            guna2DataGridView1.DataSource = PatientBL.GetAvailableDoctors();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = guna2DataGridView1.SelectedCells[0].RowIndex;
                string doctorId = guna2DataGridView1.Rows[selectedRowIndex].Cells["UserId"].Value.ToString();

                PatientBL.BookAppointment(userid , doctorId);
                MessageBox.Show("Appointment booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
