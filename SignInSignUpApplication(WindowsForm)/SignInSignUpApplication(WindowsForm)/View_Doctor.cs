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
    public partial class View_Doctor : Form
    {
        private string userID;
        private bool flag;
        public View_Doctor()
        {
            InitializeComponent();
            flag = true;

        }
        public View_Doctor(int id)
        {
            InitializeComponent();
            userID = id.ToString(); // assuming MongoDB uses string IDs
            flag = false; // show specific doctor
        }

        private void DocView_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();

            //DoctorBL.ViewQuery(flag,userID);
            //LoadDataIntoDataGridView();

        }
        private void LoadDataIntoDataGridView()
        {

            guna2DataGridView1.DataSource = DoctorBL.ViewDoctor(flag, userID);
        }


    }
}
