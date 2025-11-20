using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SignInSignUpApplication_WindowsForm_
{
    public partial class Generate_Report : Form
    {
        public Generate_Report()
        {
            InitializeComponent();
        }

        private static MongoClient client = new MongoClient("mongodb://localhost:27017");
        private static IMongoDatabase db = client.GetDatabase("HMS");

        public static void GenerateHospitalReport()
        {
            try
            {
                var patientCollection = db.GetCollection<BsonDocument>("Patient");
                var doctorCollection = db.GetCollection<BsonDocument>("Doctor");
                var roomAllocationCollection = db.GetCollection<BsonDocument>("RoomAllocation");
                var roomCollection = db.GetCollection<BsonDocument>("Room");
                var medicineCollection = db.GetCollection<BsonDocument>("Medicine");

                long totalPatients = patientCollection.CountDocuments(new BsonDocument());
                long totalDoctors = doctorCollection.CountDocuments(new BsonDocument());
                long totalRoomAllocations = roomAllocationCollection.CountDocuments(new BsonDocument());

                var roomDocs = roomCollection.Find(new BsonDocument()).ToList();
                int totalRooms = roomDocs.Count;
                int totalRoomsOccupied = roomDocs.Count(r => r.Contains("Availability") && r["Availability"].ToString().Equals("No", StringComparison.OrdinalIgnoreCase));
                int totalRoomsAvailable = roomDocs.Count(r => r.Contains("Availability") && r["Availability"].ToString().Equals("Yes", StringComparison.OrdinalIgnoreCase));

                var medicineDocs = medicineCollection.Find(new BsonDocument()).ToList();

                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "HospitalReport.pdf");

                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                using (PdfWriter writer = new PdfWriter(fs))
                using (PdfDocument pdf = new PdfDocument(writer))
                using (Document document = new Document(pdf))
                {
                    PdfFont titleFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                    PdfFont bodyFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                    document.Add(new Paragraph("Hospital Management Report")
                        .SetFont(titleFont)
                        .SetFontSize(20)
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

                    document.Add(new Paragraph($"Generated on: {DateTime.Now:dd-MM-yyyy HH:mm:ss}")
                        .SetFont(bodyFont)
                        .SetFontSize(12)
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT));

                    document.Add(new Paragraph("\nHospital Statistics:").SetFont(titleFont).SetFontSize(14));

                    Table statsTable = new Table(2).UseAllAvailableWidth();
                    statsTable.AddHeaderCell(new Cell().Add(new Paragraph("Description").SetFont(titleFont)));
                    statsTable.AddHeaderCell(new Cell().Add(new Paragraph("Count").SetFont(titleFont)));

                    statsTable.AddCell(new Cell().Add(new Paragraph("Total Patients").SetFont(bodyFont)));
                    statsTable.AddCell(new Cell().Add(new Paragraph(totalPatients.ToString()).SetFont(bodyFont)));

                    statsTable.AddCell(new Cell().Add(new Paragraph("Total Doctors").SetFont(bodyFont)));
                    statsTable.AddCell(new Cell().Add(new Paragraph(totalDoctors.ToString()).SetFont(bodyFont)));

                    statsTable.AddCell(new Cell().Add(new Paragraph("Total Patients Allocated Rooms").SetFont(bodyFont)));
                    statsTable.AddCell(new Cell().Add(new Paragraph(totalRoomAllocations.ToString()).SetFont(bodyFont)));

                    statsTable.AddCell(new Cell().Add(new Paragraph("Total Rooms").SetFont(bodyFont)));
                    statsTable.AddCell(new Cell().Add(new Paragraph(totalRooms.ToString()).SetFont(bodyFont)));

                    statsTable.AddCell(new Cell().Add(new Paragraph("Total Rooms Occupied").SetFont(bodyFont)));
                    statsTable.AddCell(new Cell().Add(new Paragraph(totalRoomsOccupied.ToString()).SetFont(bodyFont)));

                    statsTable.AddCell(new Cell().Add(new Paragraph("Total Rooms Available").SetFont(bodyFont)));
                    statsTable.AddCell(new Cell().Add(new Paragraph(totalRoomsAvailable.ToString()).SetFont(bodyFont)));

                    document.Add(statsTable);

                    document.Add(new Paragraph("\nAvailable Medicines:").SetFont(titleFont).SetFontSize(14));

                    if (medicineDocs.Count > 0)
                    {
                        Table medicineTable = new Table(2).UseAllAvailableWidth();

                        medicineTable.AddHeaderCell(new Cell().Add(new Paragraph("Medicine Name").SetFont(titleFont)));
                        medicineTable.AddHeaderCell(new Cell().Add(new Paragraph("Quantity").SetFont(titleFont)));

                        foreach (var med in medicineDocs)
                        {
                            string name = med.Contains("Name") ? med["Name"].AsString : "Unknown";
                            string quantity = med.Contains("Quantity") ? med["Quantity"].ToString() : "0";

                            medicineTable.AddCell(new Cell().Add(new Paragraph(name).SetFont(bodyFont)));
                            medicineTable.AddCell(new Cell().Add(new Paragraph(quantity).SetFont(bodyFont)));
                        }

                        document.Add(medicineTable);
                    }
                    else
                    {
                        document.Add(new Paragraph("No medicines found.").SetFont(bodyFont));
                    }
                }

                MessageBox.Show($"Report generated successfully at:\n{path}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    



        private void btnAdd_Click(object sender, EventArgs e)
        {
            GenerateHospitalReport();
        }
    }
}
