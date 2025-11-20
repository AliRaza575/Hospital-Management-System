using System;
using System.Windows.Forms;

namespace SignInSignUpApplication_WindowsForm_
{
    public partial class Update_Doctor : Form
    {
        private string userID;
        private bool flag;

        public Update_Doctor()
        {
            InitializeComponent();
            flag = true;
        }

        public Update_Doctor(string id)
        {
            InitializeComponent();
            userID = id;
            flag = false;
            txtBoxID.Hide(); // Optional
        }

        private void Update_Doctor_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = DoctorBL.ViewDoctor(flag, userID);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
                txtBoxID.Text = row.Cells["DoctorID"].Value.ToString();
                txtBoxName.Text = row.Cells["Name"].Value.ToString();
                txtBoxSpecialization.Text = row.Cells["Specialization"].Value.ToString();
                txtBoxExperience.Text = row.Cells["Experience"].Value.ToString();
                txtBoxAge.Text = row.Cells["Age"].Value.ToString();
                txtBoxFees.Text = row.Cells["Fees"].Value.ToString();
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0 || !flag)
            {
                int ID;

                if (flag)
                {
                    // Get ID from selected row (1st column is DoctorID)
                    int selectedRowIndex = guna2DataGridView1.SelectedCells[0].RowIndex;
                    ID = Convert.ToInt32(guna2DataGridView1.Rows[selectedRowIndex].Cells["DoctorID"].Value);
                }
                else
                {
                    ID = Convert.ToInt32(userID); // ID passed to constructor
                }

                string name = txtBoxName.Text;
                string specialization = txtBoxSpecialization.Text;
                string experience = txtBoxExperience.Text;
                int age = int.Parse(txtBoxAge.Text);
                int fees = int.Parse(txtBoxFees.Text);

                DoctorBL.UpdateDoctorDetails(ID, name, age, specialization, experience, fees);
                guna2DataGridView1.DataSource = DoctorBL.ViewDoctor(flag, userID); // Refresh after update
            }
            else
            {
                MessageBox.Show("Please select a doctor row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Update_Doctor_Load_1(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = DoctorBL.ViewDoctor(flag, userID);

        }
    }
}
