using MongoDB.Bson;
using MongoDB.Driver;
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
    public partial class DocDashboard : Form
    {
        private static MongoClient client = new MongoClient("mongodb://localhost:27017");
        private static IMongoDatabase db = client.GetDatabase("HMS");

        public DocDashboard()
        {
            InitializeComponent();
            guna2HtmlLabel1.Left = (guna2Panel1.Width - guna2HtmlLabel1.Width) / 2;
            guna2HtmlLabel1.Top = (guna2Panel1.Height - guna2HtmlLabel1.Height) / 2;


        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoadHospitalStatistics()
        {
            var patientCollection = db.GetCollection<BsonDocument>("Patient");
            var doctorCollection = db.GetCollection<BsonDocument>("Doctor");
            var roomCollection = db.GetCollection<BsonDocument>("Room");
            var medicineCollection = db.GetCollection<BsonDocument>("Medicine");

            // Get counts
            long totalPatients = patientCollection.CountDocuments(new BsonDocument());
            long totalDoctors = doctorCollection.CountDocuments(new BsonDocument());

            var rooms = roomCollection.Find(new BsonDocument()).ToList();
            int totalRooms = rooms.Count;
            int occupiedRooms = rooms.Count(r => r.Contains("Availability") && r["Availability"].ToString().Equals("No", StringComparison.OrdinalIgnoreCase));
            int availableRooms = rooms.Count(r => r.Contains("Availability") && r["Availability"].ToString().Equals("Yes", StringComparison.OrdinalIgnoreCase));

            long totalMedicines = medicineCollection.CountDocuments(new BsonDocument());

            // Display on labels
            guna2HtmlLabel2.Text = $"Patients: {totalPatients}";
            guna2HtmlLabel3.Text = $"Doctors: {totalDoctors}";
            guna2HtmlLabel4.Text = $"Rooms: {totalRooms}";
            guna2HtmlLabel5.Text = $"Occupied: {occupiedRooms}";
            guna2HtmlLabel6.Text = $"Available: {availableRooms}";
            guna2HtmlLabel7.Text = $"Medicines: {totalMedicines}";
        }

        private void DocDashboard_Load(object sender, EventArgs e)
        {
            LoadHospitalStatistics();
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
