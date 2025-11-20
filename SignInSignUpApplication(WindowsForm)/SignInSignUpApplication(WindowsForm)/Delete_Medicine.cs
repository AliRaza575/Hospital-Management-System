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
    public partial class Delete_Medicine : Form
    {
        public Delete_Medicine()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = guna2DataGridView1.SelectedCells[0].RowIndex;
                string medicineId = guna2DataGridView1.Rows[selectedRowIndex].Cells["MedicineID"].Value.ToString();

                string result = MedicineBL.DeleteMedicine(medicineId);
                MessageBox.Show(result, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataIntoDataGridView();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Delete_Medicine_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }
        private void LoadDataIntoDataGridView()
        {
            guna2DataGridView1.DataSource = MedicineBL.GetMedicineDataTable();
        }
    }
}
