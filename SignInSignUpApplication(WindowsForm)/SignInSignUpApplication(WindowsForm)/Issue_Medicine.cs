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
    public partial class Issue_Medicine : Form
    {
        Dictionary<string, string> patientNameIdMap = new Dictionary<string, string>();

        public Issue_Medicine()
        {
            InitializeComponent();
           
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (guna2ComboBox2.SelectedItem == null || guna2ComboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select both patient and medicine.");
                return;
            }

            string selectedName = guna2ComboBox2.SelectedItem.ToString();
            string patientId = patientNameIdMap.ContainsKey(selectedName) ? patientNameIdMap[selectedName] : null;

            string medicine = guna2ComboBox1.SelectedItem.ToString();

            if (!int.TryParse(quantity1.Text, out int quantity) || !double.TryParse(Amount.Text, out double amount))
            {
                MessageBox.Show("Please enter valid quantity and amount.");
                return;
            }

            string result = MedicineBL.IssueMedicine(patientId, medicine, quantity, amount);
            MessageBox.Show(result);
        }

        private void Issue_Medicine_Load(object sender, EventArgs e)
        {
            patientNameIdMap = MedicineBL.GetPatientNameIdMap();
            guna2ComboBox2.Items.Clear();
            foreach (var name in patientNameIdMap.Keys)
            {
                guna2ComboBox2.Items.Add(name);
            }

            // Optionally load Medicine ComboBox
            var medicines = DL.GetAllMedicines1(); // You need to implement this
            foreach (var med in medicines)
            {
                guna2ComboBox1.Items.Add(med);
            }
        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
