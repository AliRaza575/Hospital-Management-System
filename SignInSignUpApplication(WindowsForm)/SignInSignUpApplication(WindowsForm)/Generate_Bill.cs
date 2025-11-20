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
    public partial class Generate_Bill : Form
    {
        public Generate_Bill()
        {
            InitializeComponent();
        }

        private void Generate_Bill_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = BillBL.ViewBill();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                if (guna2DataGridView1.SelectedRows.Count > 0)
                {
                    string patientId = guna2DataGridView1.SelectedRows[0].Cells["PatientID"].Value?.ToString();

                    var (finalBill, roomChargePerDay, dischargeDate, isRoomAllocated, medicineCharge) = BillBL.GenerateFinalBill(patientId);

                    label7.Text = $"Patient ID: {patientId}";
                    label10.Text = $"Total Bill: {finalBill.ToString("C")}";
                    label3.Text = $"Date: {DateTime.Now.ToShortDateString()}";
                    label2.Text = $"Medicine Charges: {medicineCharge.ToString("C")}"; // NEW LINE

                    if (!isRoomAllocated)
                    {
                        label9.Text = "Room: No Room Allocated";
                        label13.Text = "Discharge Date: No Room Allocated";
                    }
                    else
                    {
                        label9.Text = $"Room Charges/Day: {roomChargePerDay?.ToString("C")}";
                        label13.Text = $"Discharge Date: {dischargeDate?.ToShortDateString()}";
                    }

                    panelBillSlip.Visible = true;
                }
                else
                {
                    MessageBox.Show("Please select a row first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
