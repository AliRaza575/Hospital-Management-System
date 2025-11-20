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
    public partial class AddDocDetails : Form
    {
        private string userID;
      
        bool flag;
        public AddDocDetails()
        {
            InitializeComponent();
            flag = true;
        }
        public AddDocDetails(string id)
        {
            InitializeComponent();
            this.userID = id;
            flag =false;
            //txtBoxID.Hide();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string ID;
            if (flag)
            {
             //   ID = txtBoxID.Text;
            }
            else
            {
                ID = userID;
            }

            string name = txtBoxName.Text;
            string specialization = txtBoxSpecialization.Text;
            string experience = txtBoxExperience.Text;
            int age = int.Parse(txtBoxAge.Text);
            int fees = int.Parse(txtBoxFees.Text);

            // Call the Business Logic to add doctor details
            DoctorBL.AddDoctor(name, age, specialization, experience, fees);

        }
    }


       

    
}
