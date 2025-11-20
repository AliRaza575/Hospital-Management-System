using iText.Kernel.XMP.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SignInSignUpApplication_WindowsForm_
{
    public partial class ADD_Medicine : Form
    {
        public ADD_Medicine()
        {
            InitializeComponent();
        }

        private void ADD_Medicine_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string medName = Name.Text.Trim();
            string medType = Type.Text.Trim();
            string medManufacturer = Manufact.Text.Trim();
            DateTime expiryDate = guna2DateTimePicker1.Value;

            if (!int.TryParse(Quantity.Text.Trim(), out int quantity))
            {
                MessageBox.Show("Quantity must be a valid number.");
                return;
            }

            string result = MedicineBL.AddMedicine(medName, medType, medManufacturer, expiryDate, quantity);
            MessageBox.Show(result);
        }
    }
}
