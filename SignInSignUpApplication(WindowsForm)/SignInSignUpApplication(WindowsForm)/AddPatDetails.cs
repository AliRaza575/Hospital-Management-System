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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using MongoDB.Bson;

namespace SignInSignUpApplication_WindowsForm_
{

    public partial class AddPatDetails : Form
    {
        private string userID;
        bool flag;
        public AddPatDetails()
        {
            InitializeComponent();
            flag = true;
        }
        public AddPatDetails(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            flag = false;
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }


        private void AddPatDetails_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxSpecialization_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string id;
            if (flag)
            {
                id = DL.GetNextPatientID(); // Auto-ID
            }
            else
            {
                id = userID; // Manual or passed ID
            }

            string name = txtBoxName.Text;
            string gender = txtBoxGender.Text;
            int height = int.Parse(txtBoxHeight.Text);
            int weight = int.Parse(txtBoxWeight.Text);
            int age = int.Parse(txtBoxAge.Text);

            var patient = new BsonDocument
    {
        { "PatientID", id },
        { "Name", name },
        { "Age", age },
        { "Gender", gender },
        { "Height", height },
        { "Weight", weight }
    };

            DL.AddPatient(patient);
            MessageBox.Show($"Patient added successfully! ID: {id}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
