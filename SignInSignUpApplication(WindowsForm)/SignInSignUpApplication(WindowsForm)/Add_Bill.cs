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
    public partial class Add_Bill : Form
    {
        private string userID;
        bool flag;
        public Add_Bill()
        {
            InitializeComponent();
            flag = true;
        }

        public Add_Bill(int id)
        {
            InitializeComponent();
            userID = id.ToString(); // MongoDB uses string _id or UserId
            flag = false;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
                if (guna2DataGridView1.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = guna2DataGridView1.SelectedCells[0].RowIndex;
                    string patientId = guna2DataGridView1.Rows[selectedRowIndex].Cells["PatientID"].Value.ToString();
                    string date = dateTimePicker1.Text;
                    int amount = int.Parse(guna2TextBox1.Text);

                    BillBL.AddBill(patientId, amount, date);
                }
                else
                {
                    MessageBox.Show("Please select a patient.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void LoadDataIntoDataGridView()
        {
            guna2DataGridView1.DataSource = DL.ViewPatientDetails();

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Bill_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource= PatientBL.ViewPatient(flag, userID);
        }
    }
}
