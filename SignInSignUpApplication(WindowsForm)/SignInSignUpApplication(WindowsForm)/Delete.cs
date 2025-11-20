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
    public partial class Delete : Form
    {
        bool flag;
        public Delete(bool flag)
        {
            InitializeComponent();
            this.flag = flag;
        }

        private void AdminDocDelete_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            //showData();
        }
        private void showData()
        {
            //AdminBL.ViewQuery(flag);
           
        }
        private void LoadDataIntoDataGridView()
        {
            guna2DataGridView1.DataSource = DL.ViewDoctorDetails();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = guna2DataGridView1.SelectedCells[0].RowIndex;
                string userId = guna2DataGridView1.Rows[selectedRowIndex].Cells["DoctorID"].Value.ToString();

                AdminBL.DeleteDoc(userId, flag); // BL decides whether to delete doctor or patient
                MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showData();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
