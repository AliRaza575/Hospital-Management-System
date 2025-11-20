using System;
using System.Data;
using System.Windows.Forms;

namespace SignInSignUpApplication_WindowsForm_
{
    public partial class PatDelete : Form
    {
        private bool flag = false;

        public PatDelete(bool flag)
        {
            InitializeComponent();
            this.flag = flag;
        }

        private void LoadDataIntoDataGridView()
        {
            guna2DataGridView1.DataSource = DL.ViewPatientDetails();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = guna2DataGridView1.SelectedCells[0].RowIndex;
                string userId = guna2DataGridView1.Rows[selectedRowIndex].Cells["PatientID"].Value.ToString();

                AdminBL.DeletePatient(userId, flag);  // Calls BL to delete doctor or patient
                MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDataIntoDataGridView(); // Refresh the grid after deletion
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PatDelete_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }
    }
}
