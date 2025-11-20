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
    public partial class PatBill : Form
    {
        string userID;
        public PatBill(string id)
        {
            InitializeComponent();
            userID = id;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
        private void LoadDataIntoDataGridView()
        {
            guna2DataGridView1.DataSource = PatientBL.GetPatientBills(userID);

        }
        private void PatBill_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Print functionality not implemented yet.");
            LoadDataIntoDataGridView();
        }
    }
}