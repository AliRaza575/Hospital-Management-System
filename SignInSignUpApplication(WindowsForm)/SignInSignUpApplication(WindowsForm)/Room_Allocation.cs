using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SignInSignUpApplication_WindowsForm_
{
    public partial class Room_Allocation : Form
    {
        private Timer timer1;

        public Room_Allocation()
        {
            InitializeComponent();

            timer1 = new Timer();
            timer1.Interval = 86400000; // 24 hours
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Room_Allocation_Load(object sender, EventArgs e)
        {
            LoadPatients();
            LoadAvailableRooms();
        }

        private void LoadPatients()
        {
            var patientList = DL.GetAllPatients2();
            guna2ComboBox1.DataSource = null;
            guna2ComboBox1.DataSource = patientList;
        }



        private void LoadAvailableRooms()
        {
            var roomList = DL.GetAvailableRooms();
            guna2ComboBox2.DataSource = null;
            guna2ComboBox2.DataSource = roomList;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedItem == null || guna2ComboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select both patient and room.");
                return;
            }

            string selectedPatient = guna2ComboBox1.SelectedItem.ToString();
            string patientId = selectedPatient.Split('-')[0].Trim();

            string selectedRoom = guna2ComboBox2.SelectedItem.ToString();
            string roomId = selectedRoom.Split('-')[0].Trim();

            DateTime allocationDate = guna2DateTimePicker1.Value.Date;
            DateTime dischargeDate = guna2DateTimePicker2.Value.Date;

            if (allocationDate < DateTime.Today || dischargeDate <= allocationDate)
            {
                MessageBox.Show("Invalid allocation or discharge date.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result = RoomBL.AllocateRoomToPatient(patientId, roomId, allocationDate, dischargeDate);
            MessageBox.Show(result, "Room Allocation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadAvailableRooms();
        }



        private void Timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void Room_Allocation_Load_1(object sender, EventArgs e)
        {
            LoadPatients();
            LoadAvailableRooms();
            DL.UpdateRoomAvailabilityOnDischarge();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
