using Guna.UI2.WinForms;
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
    public partial class Delete_Allocation : Form
    {
        public Delete_Allocation()
        {
            InitializeComponent();
        }

        private void LoadPatients()
        {
            var patientList = DL.GetAllPatients2();
            guna2ComboBox1.DataSource = null;
            guna2ComboBox1.DataSource = patientList;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a patient.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedPatient = guna2ComboBox1.SelectedItem.ToString();
            string patientId = selectedPatient.Split('-')[0].Trim();

            var confirmResult = MessageBox.Show("Are you sure you want to remove this room allocation?",
                                                 "Confirm Remove",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                string result = RoomBL.RemoveRoomAllocationForPatient(patientId);
                MessageBox.Show(result, "Remove Room Allocation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPatients(); // Refresh list after deletion
            }
        }

        private void Delete_Allocation_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }
    }
        
}
