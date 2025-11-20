using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSignUpApplication_WindowsForm_
{
    public partial class View_Patient : Form
    {
        private string userID;
        bool flag;
        public View_Patient()
        {
            InitializeComponent();
            flag = true;
        }
        public View_Patient(string id)
        {
            InitializeComponent();
            userID = id;
            flag = false;
        }

        private void PatView_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();

            //PatientBL.ViewQuery(flag, userID);
            //LoadDataIntoDataGridView();
        }
        private void LoadDataIntoDataGridView()
        {
            guna2DataGridView1.DataSource = PatientBL.ViewPatient(flag, userID);


        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
