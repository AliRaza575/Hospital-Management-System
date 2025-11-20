using System;
using System.Data;
using System.Windows.Forms;

namespace SignInSignUpApplication_WindowsForm_
{
    public partial class Update_Patient : Form
    {
        private string userID;
        private bool flag;

        public Update_Patient()
        {
            InitializeComponent();
            flag = true; // Show all patients
        }

        public Update_Patient(string id)
        {
            InitializeComponent();
            userID = id;
            flag = false; // View specific patient
            txtBoxID.Hide(); // Optional: Hide PatientID input
        }

        private void Update_Patient_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0 || !flag)
            {
                string ID;

                if (flag)
                {
                    int selectedRowIndex = guna2DataGridView1.SelectedCells[0].RowIndex;
                    ID = guna2DataGridView1.Rows[selectedRowIndex].Cells["PatientID"].Value.ToString();
                }
                else
                {
                    ID = userID;
                }

                string name = txtBoxName.Text;
                string gender = txtBoxGender.Text;
                int age = int.Parse(txtBoxAge.Text);
                int height = int.Parse(txtBoxHeight.Text);
                int weight = int.Parse(txtBoxWeight.Text);

                PatientBL.UpdatePatient(ID, name, age, gender, height, weight);
                guna2DataGridView1.DataSource = PatientBL.ViewPatient(flag, userID);

                MessageBox.Show("Patient updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a patient row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        public void loaddatagridview()
        {
            guna2DataGridView1.DataSource = PatientBL.ViewPatient(flag, userID);
        }
        private void Update_Patient_Load_1(object sender, EventArgs e)
        {
           loaddatagridview();
        }
    }
}
