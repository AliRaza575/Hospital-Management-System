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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();

        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    if (guna2DataGridView1.SelectedRows.Count > 0)
        //        if (guna2DataGridView1.SelectedRows.Count > 0)
        //        {
        //            int selectedRowIndex = guna2DataGridView1.SelectedCells[0].RowIndex;
        //            string patientId = guna2DataGridView1.Rows[selectedRowIndex].Cells["PatientID"].Value.ToString();
        //            string date = dateTimePicker1.Text;
        //            int amount = int.Parse(billtxt.Text);

        //            AdminBL.AddBill(patientId, amount, date);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please select a patient.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //}

        private void Bill_Load(object sender, EventArgs e)
        {
            //AdminBL.ShowBillQuery();
            LoadDataIntoDataGridView();
        }
        private void LoadDataIntoDataGridView()
        {
            guna2DataGridView1.DataSource = DL.ViewPatientDetails();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = BillBL.ViewBill();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = guna2DataGridView1.SelectedCells[0].RowIndex;

                // BillID is in the first column (index 0)
                string billId = guna2DataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();

                bool deleted = BillBL.DeleteBill(billId);

                if (deleted)
                {
                    MessageBox.Show("Bill deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guna2DataGridView1.DataSource = BillBL.ViewBill(); // Refresh the DataGrid
                }
                else
                {
                    MessageBox.Show("Bill ID not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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
        private void panelBillSlip_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
    
