using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSignUpApplication_WindowsForm_
{
    internal class DL
    {
        // MongoDB connection
        private static MongoClient client = new MongoClient("mongodb://localhost:27017");
        private static IMongoDatabase db = client.GetDatabase("HMS");
        private static readonly IMongoCollection<BsonDocument> medicineCollection = db.GetCollection<BsonDocument>("Medicine");
        private static readonly IMongoCollection<BsonDocument> counterCollection= db.GetCollection<BsonDocument>("Counters");



        // USER
        public static void AddUser(BsonDocument user)
        {
            var users = db.GetCollection<BsonDocument>("Users");
            users.InsertOne(user);
        }

        public static string GetUserID(string username, string password)
        {
            var users = db.GetCollection<BsonDocument>("Users");
            var filter = Builders<BsonDocument>.Filter.Eq("Username", username) & Builders<BsonDocument>.Filter.Eq("Password", password);
            var user = users.Find(filter).FirstOrDefault();
            return user != null ? user["UserId"].AsString : null;
        }

        public static string GetUserRole(string userId)
        {
            var users = db.GetCollection<BsonDocument>("Users");
            var filter = Builders<BsonDocument>.Filter.Eq("UserId", userId);
            var user = users.Find(filter).FirstOrDefault();
            return user != null ? user["Role"].AsString : null;
        }

        //---------------------------------------------------------------------------
        //----------------------------------------- DOCTOR --------------------------
        //---------------------------------------------------------------------------
        public static void AddDoctor(BsonDocument doctor)
        {
            try
            {
                var client = new MongoClient("mongodb://localhost:27017");
                var db = client.GetDatabase("HMS");
                var doctors = db.GetCollection<BsonDocument>("Doctor");

                int doctorId = doctor["DoctorID"].AsInt32;

                var filter = Builders<BsonDocument>.Filter.Eq("DoctorID", doctorId);
                var existingDoctor = doctors.Find(filter).FirstOrDefault();

                if (existingDoctor == null)
                {
                    doctors.InsertOne(doctor);
                    MessageBox.Show("Doctor added successfully!");
                }
                else
                {
                    MessageBox.Show("Doctor with this ID already exists.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static int GetNextDoctorID()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var db = client.GetDatabase("HMS");
            var counters = db.GetCollection<BsonDocument>("Counters");

            var filter = Builders<BsonDocument>.Filter.Eq("_id", "DoctorID");
            var update = Builders<BsonDocument>.Update.Inc("seq", 1);
            var options = new FindOneAndUpdateOptions<BsonDocument>
            {
                IsUpsert = true,
                ReturnDocument = ReturnDocument.After
            };

            var result = counters.FindOneAndUpdate(filter, update, options);
            return result["seq"].AsInt32;
        }

        public static void UpdateDoctorInDatabase(int id, string name, int age, string specialization, string experience, int fees)
        {
            try
            {
                var doctors = db.GetCollection<BsonDocument>("Doctor");

                var filter = Builders<BsonDocument>.Filter.Eq("DoctorID", id); // ID as int
                var existingDoctor = doctors.Find(filter).FirstOrDefault();

                if (existingDoctor == null)
                {
                    MessageBox.Show("Doctor not found with the provided ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var update = Builders<BsonDocument>.Update
                                .Set("Name", name)
                                .Set("Age", age)
                                .Set("Specialization", specialization)
                                .Set("Experience", experience)
                                .Set("Fees", fees);

                doctors.UpdateOne(filter, update);

                MessageBox.Show("Doctor information updated successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static object GetDoctors(bool flag, string userID)
        {
            var doctors = db.GetCollection<BsonDocument>("Doctor");
            if (flag)
            {
                return doctors.Find(new BsonDocument()).ToList();
            }
            else
            {
                var filter = Builders<BsonDocument>.Filter.Eq("DoctorID", userID);
                return doctors.Find(filter).ToList();
            }
        }


        public static void DeleteDoctor(string id)
        {
            var doctors = db.GetCollection<BsonDocument>("Doctor");
            var filter = Builders<BsonDocument>.Filter.Eq("DoctorID", id);
            doctors.DeleteOne(filter);
        }

        public static bool DoctorExists(string id)
        {
            var doctors = db.GetCollection<BsonDocument>("Doctor");
            var filter = Builders<BsonDocument>.Filter.Eq("DoctorID", id);
            var doctor = doctors.Find(filter).FirstOrDefault();
            return doctor != null;
        }
        public static List<BsonDocument> GetAllDoctors()
        {
            var doctors = db.GetCollection<BsonDocument>("Doctor");
            return doctors.Find(new BsonDocument()).ToList();
        }
        public static DataTable ViewDoctorDetails()
        {
            var table = new DataTable();
            table.Columns.Add("DoctorID");
            table.Columns.Add("Name");
            table.Columns.Add("Age");
            table.Columns.Add("Specialization");
            table.Columns.Add("Experience");

            var collection = db.GetCollection<BsonDocument>("Doctor");

            // Sort doctors by DoctorID (ascending)
            var sort = Builders<BsonDocument>.Sort.Ascending("DoctorID");
            var docs = collection.Find(new BsonDocument()).Sort(sort).ToList();

            foreach (var doc in docs)
            {
                table.Rows.Add(
                    doc.GetValue("DoctorID", "").ToInt32(),
                    doc.GetValue("Name", "").AsString,
                    doc.GetValue("Age", 0).ToInt32(),
                    doc.GetValue("Specialization", "").AsString,
                    doc.GetValue("Experience", "").AsString
                );
            }

            return table;
        }

        public static DataTable ViewDoctorById(string userId)
        {
            var table = new DataTable();
            table.Columns.Add("DoctorID");
            table.Columns.Add("Name");
            table.Columns.Add("Age");
            table.Columns.Add("Gender");
            table.Columns.Add("Height");
            table.Columns.Add("Weight");

            var collection = db.GetCollection<BsonDocument>("Doctor");
            var filter = Builders<BsonDocument>.Filter.Eq("DoctorID", userId);
            var doc = collection.Find(filter).FirstOrDefault();

            if (doc != null)
            {
                table.Rows.Add(
                    doc.GetValue("DoctorID", "").AsString,
                    doc.GetValue("Name", "").AsString,
                    doc.GetValue("Age", 0).ToInt32(),
                    doc.GetValue("Gender", "").AsString,
                    doc.GetValue("Height", 0).ToInt32(),
                    doc.GetValue("Weight", 0).ToInt32()
                );
            }

            return table;
        }

        //----------------------------------------------------------------------
        //--------------------------- PATIENT ----------------------------------
        //----------------------------------------------------------------------
        public static void AddPatient(BsonDocument patient)
        {
            var patients = db.GetCollection<BsonDocument>("Patient");
            patients.InsertOne(patient);

        }

        public static string GetNextPatientID()
        {
            var counters = db.GetCollection<BsonDocument>("Counters");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", "PatientID");
            var update = Builders<BsonDocument>.Update.Inc("sequence_value", 1);
            var options = new FindOneAndUpdateOptions<BsonDocument>
            {
                ReturnDocument = ReturnDocument.After,
                IsUpsert = true
            };

            var result = counters.FindOneAndUpdate(filter, update, options);
            int sequence = result["sequence_value"].AsInt32;
            return $"P{sequence:D3}"; // Format as P001, P002, etc.
        }


        public static bool PatientExists(string id)
        {
            var patientCollection = db.GetCollection<BsonDocument>("Patient");
            return patientCollection.Find(Builders<BsonDocument>.Filter.Eq("PatientID", id.Trim())).Any();
        }

        public static void UpdatePatient(string id, string name, int age, string gender, int height, int weight)
        {
            var patients = db.GetCollection<BsonDocument>("Patient");
            var filter = Builders<BsonDocument>.Filter.Eq("PatientID", id);
            var update = Builders<BsonDocument>.Update
                .Set("Name", name)
                .Set("Age", age)
                .Set("Gender", gender)
                .Set("Height", height)
                .Set("Weight", weight);

            patients.UpdateOne(filter, update);
        }

        public static void DeletePatient(string id)
        {
            var patientCollection = db.GetCollection<BsonDocument>("Patient");
            var roomAllocationCollection = db.GetCollection<BsonDocument>("RoomAllocation");
            var issuedMedicineCollection = db.GetCollection<BsonDocument>("IssuedMedicines");
            var filter = Builders<BsonDocument>.Filter.Eq("PatientID", id);

            // Delete the patient document
            var patientFilter = Builders<BsonDocument>.Filter.Eq("PatientID", id);
            patientCollection.DeleteOne(patientFilter);

            // Delete any room allocation for this patient
            var roomFilter = Builders<BsonDocument>.Filter.Eq("PatientID", id);
            roomAllocationCollection.DeleteMany(roomFilter);

            // Delete any issued medicines for this patient
            var medicineFilter = Builders<BsonDocument>.Filter.Eq("PatientID", id);
            issuedMedicineCollection.DeleteMany(medicineFilter);
            patientCollection.DeleteOne(filter);

        }
        public static DataTable ViewPatientDetails()
        {
            var table = new DataTable();
            table.Columns.Add("PatientID");
            table.Columns.Add("Name");
            table.Columns.Add("Age");
            table.Columns.Add("Gender");
            table.Columns.Add("Height");
            table.Columns.Add("Weight");
            table.Columns.Add("RoomNumber");
            table.Columns.Add("DischargeDate");
            table.Columns.Add("IssuedMedicine");

            var patientCollection = db.GetCollection<BsonDocument>("Patient");
            var roomAllocationCollection = db.GetCollection<BsonDocument>("RoomAllocation");
            var issuedMedicineCollection = db.GetCollection<BsonDocument>("IssuedMedicines");

            var sort = Builders<BsonDocument>.Sort.Ascending("PatientID");
            var patientDocs = patientCollection.Find(new BsonDocument()).Sort(sort).ToList();

            foreach (var patient in patientDocs)
            {
                string patientID = patient.GetValue("PatientID", "").ToString();

                var roomFilter = Builders<BsonDocument>.Filter.Eq("PatientID", patientID);
                var roomDoc = roomAllocationCollection.Find(roomFilter).FirstOrDefault();

                string roomNumber = "Not Allocated";
                string dischargeDate = "Not Assigned";

                if (roomDoc != null)
                {
                    roomNumber = roomDoc.GetValue("RoomID", "Not Allocated").ToString();
                    if (roomDoc.Contains("DischargeDate") && DateTime.TryParse(roomDoc["DischargeDate"].ToString(), out DateTime parsedDate))
                        dischargeDate = parsedDate.ToString("yyyy-MM-dd");
                }

                var medFilter = Builders<BsonDocument>.Filter.Eq("PatientID", patientID);
                var medDocs = issuedMedicineCollection.Find(medFilter).ToList();

                string issuedMedicines = "No medicine issued";
                if (medDocs.Any())
                {
                    List<string> medList = new List<string>();
                    foreach (var med in medDocs)
                    {
                        string name = med.GetValue("MedicineName", "Unknown").ToString();
                        int qty = med.GetValue("Quantity", 0).ToInt32();
                        medList.Add($"{name} (x{qty})");
                    }
                    issuedMedicines = string.Join(", ", medList);
                }

                table.Rows.Add(
                    patientID,
                    patient.GetValue("Name", ""),
                    patient.GetValue("Age", 0),
                    patient.GetValue("Gender", ""),
                    patient.GetValue("Height", 0),
                    patient.GetValue("Weight", 0),
                    roomNumber,
                    dischargeDate,
                    issuedMedicines
                );
            }

            return table;
        }



        public static DataTable ViewPatientById(string userId)
        {
            var table = new DataTable();
            table.Columns.Add("PatientID");
            table.Columns.Add("Name");
            table.Columns.Add("Age");
            table.Columns.Add("Gender");
            table.Columns.Add("Height");
            table.Columns.Add("Weight");

            var collection = db.GetCollection<BsonDocument>("Patient");
            var filter = Builders<BsonDocument>.Filter.Eq("PatientID", userId);
            var doc = collection.Find(filter).FirstOrDefault();

            if (doc != null)
            {
                table.Rows.Add(
                    doc["PatientID"].AsString,
                    doc["Name"].AsString,
                    doc["Age"].AsInt32,
                    doc["Gender"].AsString,
                    doc["Height"].AsInt32,
                    doc["Weight"].AsInt32
                );
            }

            return table;
        }
        public static List<BsonDocument> GetAllPatients()
        {
            var patients = db.GetCollection<BsonDocument>("Patient");
            return patients.Find(new BsonDocument()).ToList();
        }

        // BILL

        public static DataTable GetAppointmentsWithDoctorDetails()
        {
            var appointmentCollection = db.GetCollection<BsonDocument>("Appointment");
            var doctorCollection = db.GetCollection<BsonDocument>("Doctor");
            var patientCollection = db.GetCollection<BsonDocument>("Patient");

            var appointments = appointmentCollection.Find(new BsonDocument()).ToList();
            var table = new DataTable();

            table.Columns.Add("PatID");
            table.Columns.Add("PatName");
            table.Columns.Add("DocName");
            table.Columns.Add("Specialization");
            table.Columns.Add("Fees");

            foreach (var appt in appointments)
            {
                var patId = appt["PatientID"].AsString;
                var docId = appt["DoctorID"].AsString;

                var patient = patientCollection.Find(Builders<BsonDocument>.Filter.Eq("UserId", patId)).FirstOrDefault();
                var doctor = doctorCollection.Find(Builders<BsonDocument>.Filter.Eq("UserId", docId)).FirstOrDefault();

                if (patient != null && doctor != null)
                {
                    table.Rows.Add(
                        patId,
                        patient["Name"].AsString,
                        doctor["Name"].AsString,
                        doctor["Specialization"].AsString,
                        doctor["Fees"].AsInt32
                    );
                }
            }

            return table;
        }


        public static List<BsonDocument> GetPatientBills(string patientId)
        {
            var bills = db.GetCollection<BsonDocument>("Bill");
            var filter = Builders<BsonDocument>.Filter.Eq("PatientID", patientId);
            return bills.Find(filter).ToList();
        }
        //----------------------------------------------------------------------------
        //------------------------------ SALARY --------------------------------------
        //----------------------------------------------------------------------------

        public static void AddSalary(BsonDocument salary)          // ADD SALARY
        {
            var salaries = db.GetCollection<BsonDocument>("Salary");
            salaries.InsertOne(salary);
        }

        public static bool IsSalaryAlreadyIssued(string doctorId, string date)
        {
            var salaries = db.GetCollection<BsonDocument>("Salary");

            var filter = Builders<BsonDocument>.Filter.Eq("DoctorID", doctorId) &
                         Builders<BsonDocument>.Filter.Eq("Date", date);

            var existingSalary = salaries.Find(filter).FirstOrDefault();

            return existingSalary != null;
        }

        public static int GetNextSalaryId()
        {
            var counters = db.GetCollection<BsonDocument>("Counters");

            var filter = Builders<BsonDocument>.Filter.Eq("_id", "salaryid");
            var update = Builders<BsonDocument>.Update.Inc("sequence_value", 1);
            var options = new FindOneAndUpdateOptions<BsonDocument>
            {
                IsUpsert = true,
                ReturnDocument = ReturnDocument.After
            };

            var result = counters.FindOneAndUpdate(filter, update, options);
            return result["sequence_value"].AsInt32;
        }

        public static DataTable ViewSalary()
        {
            var table = new DataTable();
            table.Columns.Add("SalaryID");
            table.Columns.Add("DoctorID");
            table.Columns.Add("Salary");
            table.Columns.Add("Date");

            var salaryCollection = db.GetCollection<BsonDocument>("Salary");

            // Sort salaries by SalaryID ascending
            var sort = Builders<BsonDocument>.Sort.Ascending("SalaryID");
            var salaryList = salaryCollection.Find(new BsonDocument()).Sort(sort).ToList();

            foreach (var doc in salaryList)
            {
                string salaryId = doc.Contains("SalaryID") ? doc["SalaryID"].ToString() : "N/A";
                string doctorId = doc.Contains("DoctorID") ? doc["DoctorID"].AsString : "N/A";
                string salary = doc.Contains("Salary") ? doc["Salary"].ToString() : "N/A";

                string date = "N/A";
                if (doc.Contains("Date"))
                {
                    var dateVal = doc["Date"];
                    if (dateVal.BsonType == BsonType.DateTime)
                    {
                        date = dateVal.ToLocalTime().ToShortDateString();
                    }
                    else
                    {
                        date = dateVal.ToString();
                    }
                }

                table.Rows.Add(salaryId, doctorId, salary, date);
            }

            return table;
        }


        public static bool DeleteSalary(string salaryId)
        {
            var salaries = db.GetCollection<BsonDocument>("Salary");
            // If SalaryID is stored as int
            int parsedSalaryId = int.Parse(salaryId); // Parse from string
            var filter = Builders<BsonDocument>.Filter.Eq("SalaryID", parsedSalaryId);
            var result = salaries.DeleteOne(filter);
            return result.DeletedCount > 0;
        }


        public static List<BsonDocument> GetDoctorSalaries(string doctorId)
        {
            var salaries = db.GetCollection<BsonDocument>("Salary");
            var filter = Builders<BsonDocument>.Filter.Eq("DoctorID", doctorId);
            return salaries.Find(filter).ToList();
        }
        //----------------------------------------------------------------------------
        //-----------------------------------Bill-------------------------------------
        //----------------------------------------------------------------------------
        public static void AddBill(BsonDocument bill)
        {
            var bills = db.GetCollection<BsonDocument>("Bill");
            bills.InsertOne(bill);
        }

        public static bool IsBillAlreadyIssued(string patientId, string date)
        {
            var bills = db.GetCollection<BsonDocument>("Bill");

            var filter = Builders<BsonDocument>.Filter.Eq("PatientID", patientId) &
                         Builders<BsonDocument>.Filter.Eq("Date", date);

            var existingBill = bills.Find(filter).FirstOrDefault();
            return existingBill != null;
        }

        public static int GetNextBillId()
        {
            var bills = db.GetCollection<BsonDocument>("Bill");
            var sort = Builders<BsonDocument>.Sort.Descending("BillID");
            var lastBill = bills.Find(new BsonDocument()).Sort(sort).Limit(1).FirstOrDefault();

            if (lastBill != null && lastBill.Contains("BillID"))
            {
                return lastBill["BillID"].ToInt32() + 1;
            }
            else
            {
                return 1; // Start from 1 if no bills exist
            }
        }

        public static DataTable ViewBill()
        {
            var table = new DataTable();
            table.Columns.Add("BillID");
            table.Columns.Add("PatientID");
            table.Columns.Add("Amount");
            table.Columns.Add("Date");

            var billCollection = db.GetCollection<BsonDocument>("Bill");
            var billList = billCollection.Find(new BsonDocument()).ToList();

            foreach (var doc in billList)
            {
                string billId = doc.Contains("BillID") ? doc["BillID"].ToString() : "N/A";
                string patientId = doc.Contains("PatientID") ? doc["PatientID"].AsString : "N/A";
                string amount = doc.Contains("Amount") ? doc["Amount"].ToString() : "N/A";

                string date = "N/A";
                if (doc.Contains("Date"))
                {
                    var dateVal = doc["Date"];
                    if (dateVal.BsonType == BsonType.DateTime)
                    {
                        date = dateVal.ToLocalTime().ToShortDateString();
                    }
                    else
                    {
                        date = dateVal.ToString();
                    }
                }

                table.Rows.Add(billId, patientId, amount, date);
            }

            return table;
        }
        public static BsonDocument GetBillById(int billId)
        {
            var collection = db.GetCollection<BsonDocument>("Bill");

            var filter = Builders<BsonDocument>.Filter.Eq("BillID", billId);
            var billDoc = collection.Find(filter).FirstOrDefault();

            return billDoc; // You can return a model class if you prefer
        }
        public static bool DeleteBill(string billId)
        {
            var bills = db.GetCollection<BsonDocument>("Bill");

            // Assuming BillID is stored as int in MongoDB
            int parsedBillId = int.Parse(billId);
            var filter = Builders<BsonDocument>.Filter.Eq("BillID", parsedBillId);

            var result = bills.DeleteOne(filter);
            return result.DeletedCount > 0;
        }

        // DL.cs
        // DL.cs
        public static double GetBillAmount(string patientId)
        {
            var billCollection = db.GetCollection<BsonDocument>("Bill");
            var filter = Builders<BsonDocument>.Filter.Eq("PatientID", patientId);
            var bill = billCollection.Find(filter).FirstOrDefault();

            if (bill != null && bill.Contains("Amount"))
            {
                return bill["Amount"].ToDouble();
            }

            return 0.0;
        }


        public static (double TotalAmount, double? RoomChargePerDay, DateTime? DischargeDate, bool IsRoomAllocated, double MedicineCharge) CalculateTotalBill(string patientId)
        {
            var allocCollection = db.GetCollection<BsonDocument>("RoomAllocation");
            var allocFilter = Builders<BsonDocument>.Filter.Eq("PatientID", patientId);
            var allocDoc = allocCollection.Find(allocFilter).FirstOrDefault();

            double roomTotal = 0;
            double? perDayCharge = null;
            DateTime? dischargeDate = null;
            bool isRoomAllocated = false;

            if (allocDoc != null)
            {
                isRoomAllocated = true;

                string roomId = allocDoc.GetValue("RoomID", "").ToString();
                DateTime allocDate = ConvertToDateTime(allocDoc.GetValue("AllocationDate", DateTime.UtcNow));
                dischargeDate = allocDoc.Contains("DischargeDate")
                    ? ConvertToDateTime(allocDoc["DischargeDate"])
                    : DateTime.UtcNow;

                int days = (dischargeDate.Value - allocDate).Days;
                if (days <= 0) days = 1;

                var roomCollection = db.GetCollection<BsonDocument>("Room");
                var roomDoc = roomCollection.Find(Builders<BsonDocument>.Filter.Eq("RoomID", roomId)).FirstOrDefault();

                perDayCharge = roomDoc?.GetValue("ChargesPerDay", 0).ToDouble() ?? 0;
                roomTotal = perDayCharge.Value * days;
            }

            var billCollection = db.GetCollection<BsonDocument>("Bill");
            var billDoc = billCollection.Find(Builders<BsonDocument>.Filter.Eq("PatientID", patientId)).FirstOrDefault();
            double treatmentAmount = billDoc?.GetValue("Amount", 0).ToDouble() ?? 0;

            var issuedMedCollection = db.GetCollection<BsonDocument>("IssuedMedicines");
            var medDocs = issuedMedCollection.Find(Builders<BsonDocument>.Filter.Eq("PatientID", patientId)).ToList();
            double medicineTotal = medDocs.Sum(m => m.Contains("Amount") ? m["Amount"].ToDouble() : 0);

            double total = treatmentAmount + roomTotal + medicineTotal;

            return (total, perDayCharge, dischargeDate, isRoomAllocated, medicineTotal);
        }


        private static DateTime ConvertToDateTime(BsonValue bsonValue)
        {
            if (bsonValue.BsonType == BsonType.String)
            {
                if (DateTime.TryParse(bsonValue.AsString, out DateTime parsedDate))
                {
                    return parsedDate;
                }
                else
                {
                    throw new Exception($"Unable to parse '{bsonValue.AsString}' to DateTime.");
                }
            }
            else if (bsonValue.BsonType == BsonType.DateTime)
            {
                return bsonValue.ToUniversalTime();
            }

            throw new Exception("BsonValue is not a valid DateTime or String.");
        }




        // APPOINTMENT
        public static void AddAppointment(BsonDocument appointment)
        {
            var appointments = db.GetCollection<BsonDocument>("Appointment");
            appointments.InsertOne(appointment);
        }
        public static void AddDoctorSalary(string doctorId, int salary)
        {
            var collection = db.GetCollection<BsonDocument>("DoctorSalary");

            var doc = new BsonDocument
        {
            { "UserId", doctorId },
            { "Salary", salary },
            { "Date", DateTime.Now }
        };

            collection.InsertOne(doc);
        }
        public static DataTable GetAppointmentsForDoctor(string doctorId)
        {
            var table = new DataTable();
            table.Columns.Add("AppointmentId");
            table.Columns.Add("PatientName");
            table.Columns.Add("Date");
            table.Columns.Add("Time");
            table.Columns.Add("Status");

            var collection = db.GetCollection<BsonDocument>("Appointments");

            var filter = Builders<BsonDocument>.Filter.Eq("DoctorId", doctorId);
            var docs = collection.Find(filter).ToList();

            foreach (var doc in docs)
            {
                table.Rows.Add(
                    doc.GetValue("AppointmentId", "").ToString(),
                    doc.GetValue("PatientName", "").ToString(),
                    doc.GetValue("Date", "").ToString(),
                    doc.GetValue("Time", "").ToString(),
                    doc.GetValue("Status", "").ToString()
                );
            }

            return table;
        }

        public static DataTable FetchDoctorSalary(string doctorId)
        {
            var table = new DataTable();
            table.Columns.Add("UserId");
            table.Columns.Add("Name");
            table.Columns.Add("Salary");

            var collection = db.GetCollection<BsonDocument>("Doctors");

            var filter = Builders<BsonDocument>.Filter.Eq("UserId", doctorId);
            var doctor = collection.Find(filter).FirstOrDefault();

            if (doctor != null)
            {
                table.Rows.Add(
                    doctor.GetValue("UserId", "").ToString(),
                    doctor.GetValue("Name", "").ToString(),
                    doctor.GetValue("Salary", "Not Set").ToString()
                );
            }

            return table;
        }
        public static DataTable FetchDoctorList()
        {
            var table = new DataTable();
            table.Columns.Add("UserId");
            table.Columns.Add("Name");
            table.Columns.Add("Specialization");

            var doctors = db.GetCollection<BsonDocument>("Doctors").Find(new BsonDocument()).ToList();

            foreach (var doc in doctors)
            {
                table.Rows.Add(
                    doc.GetValue("UserId", "").ToString(),
                    doc.GetValue("Name", "").ToString(),
                    doc.GetValue("Specialization", "").ToString()
                );
            }

            return table;
        }

        public static void AddAppointment(string patientId, string doctorId)
        {
            var appointment = new BsonDocument
        {
            { "PatientId", patientId },
            { "DoctorId", doctorId },
            { "Date", DateTime.Now }
        };

            db.GetCollection<BsonDocument>("Appointments").InsertOne(appointment);
        }
        public static DataTable FetchPatientBills(string patientId)
        {
            var table = new DataTable();
            table.Columns.Add("BillId");
            table.Columns.Add("PatientId");
            table.Columns.Add("Amount");
            table.Columns.Add("Date");

            var filter = Builders<BsonDocument>.Filter.Eq("PatientId", patientId);
            var bills = db.GetCollection<BsonDocument>("Bills").Find(filter).ToList();

            foreach (var bill in bills)
            {
                table.Rows.Add(
                    bill.GetValue("BillId", "").ToString(),
                    bill.GetValue("PatientId", "").ToString(),
                    bill.GetValue("Amount", 0).ToString(),
                    bill.GetValue("Date", DateTime.Now).ToLocalTime().ToString("yyyy-MM-dd")
                );
            }

            return table;
        }

        //----------------------------------------------------------------------------
        //----------------------------ROOM--------------------------------------------
        //----------------------------------------------------------------------------

        public static bool RoomExists(string id)
        {
            var rooms = db.GetCollection<BsonDocument>("Room");
            var filter = Builders<BsonDocument>.Filter.Eq("RoomID", id);
            return rooms.Find(filter).Any();
        }

        public static void AddRoom(BsonDocument room)
        {
            var rooms = db.GetCollection<BsonDocument>("Room");
            rooms.InsertOne(room);
        }

        public static int GetNextRoomSequence()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", "RoomID");
            var update = Builders<BsonDocument>.Update.Inc("seq", 1);
            var options = new FindOneAndUpdateOptions<BsonDocument>
            {
                IsUpsert = true,
                ReturnDocument = ReturnDocument.After
            };

            var result = counterCollection.FindOneAndUpdate(filter, update, options);
            return result["seq"].AsInt32;
        }

        private static IMongoCollection<BsonDocument> roomCollection = db.GetCollection<BsonDocument>("Room");
        private static IMongoCollection<BsonDocument> roomAllocationCollection = db.GetCollection<BsonDocument>("RoomAllocation");
        private static IMongoCollection<BsonDocument> patientCollection = db.GetCollection<BsonDocument>("Patient");



        // Check if the patient is already assigned a room


        // Check if patient already assigned
        public static bool IsPatientAlreadyAssignedRoom(string patientId)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("PatientID", patientId);
            return roomAllocationCollection.Find(filter).Any();
        }

        // Get room availability
        public static string GetRoomAvailability(string roomId)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("RoomID", roomId);
            var room = roomCollection.Find(filter).FirstOrDefault();

            if (room != null)
            {
                return room.Contains("Availability") ? room["Availability"].ToString() : "No";
            }

            return "No";
        }

        // Add room allocation
        public static void AddRoomAllocation(string patientId, string roomId, DateTime allocationDate, DateTime dischargeDate)
        {
            var roomAllocation = new BsonDocument
    {
        { "PatientID", patientId },
        { "RoomID", roomId },
        { "AllocationDate", allocationDate },
        { "DischargeDate", dischargeDate }
    };
            roomAllocationCollection.InsertOne(roomAllocation);
        }

        // Update room availability
        public static void UpdateRoomAvailability(string roomId, string availabilityStatus)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("RoomID", roomId);
            var update = Builders<BsonDocument>.Update.Set("Availability", availabilityStatus);
            roomCollection.UpdateOne(filter, update);
        }

        // Automatically update rooms after discharge
        public static void UpdateRoomAvailabilityOnDischarge()
        {
            DateTime currentDate = DateTime.Today;

            // Filter to find room allocations where discharge date has passed
            var filter = Builders<BsonDocument>.Filter.Lte("DischargeDate", currentDate);
            var allocationsToUpdate = roomAllocationCollection.Find(filter).ToList();

            foreach (var allocation in allocationsToUpdate)
            {
                if (allocation.Contains("RoomID"))
                {
                    string roomId = allocation["RoomID"].ToString();

                    // Step 1: Mark room as available
                    UpdateRoomAvailability(roomId, "Yes");

                    // Step 2: Delete the allocation record (the patient is discharged)
                    var allocationFilter = Builders<BsonDocument>.Filter.Eq("RoomID", roomId);
                    roomAllocationCollection.DeleteOne(allocationFilter);
                }
            }
        }


        // Get available rooms
        public static List<string> GetAvailableRooms()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Availability", "Yes");
            var rooms = roomCollection.Find(filter).ToList();

            List<string> roomList = new List<string>();

            foreach (var room in rooms)
            {
                string roomId = room.GetValue("RoomID", "").AsString;
                string roomType = room.GetValue("RoomType", "").AsString;
                roomList.Add($"{roomId} - {roomType}");
            }

            return roomList;
        }


        // Get all patients
        public static List<string> GetAllPatients2()
        {
            var patients = patientCollection.Find(_ => true).ToList();
            List<string> patientList = new List<string>();

            foreach (var patient in patients)
            {
                string patientId = patient.GetValue("PatientID", "").AsString;
                string name = patient.GetValue("Name", "").AsString;
                patientList.Add($"{patientId} - {name}");
            }

            return patientList;
        }


        public static string RemoveRoomAllocation(string patientId)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("PatientID", patientId);
            var allocation = roomAllocationCollection.Find(filter).FirstOrDefault();

            if (allocation == null)
            {
                return "No room allocation found for this patient.";
            }

            string roomId = allocation["RoomID"].AsString;

            roomAllocationCollection.DeleteOne(filter);

            UpdateRoomAvailability(roomId, "Yes");

            return "Room allocation successfully removed and room is now available.";
        }


        public static DataTable ViewRoomDetails()
        {
            var table = new DataTable();
            table.Columns.Add("RoomID");
            table.Columns.Add("RoomType");
            table.Columns.Add("ChargesPerDay");
            table.Columns.Add("Availability");

            var collection = db.GetCollection<BsonDocument>("Room");

            var sort = Builders<BsonDocument>.Sort.Ascending("RoomID");
            var docs = collection.Find(new BsonDocument()).Sort(sort).ToList();

            foreach (var doc in docs)
            {
                table.Rows.Add(
                    doc.GetValue("RoomID", "").ToString(),
                    doc.GetValue("RoomType", "").ToString(),
                    doc.GetValue("ChargesPerDay", 0).ToInt32(),
                    doc.GetValue("Availability", "").ToString()
                );
            }

            return table;
        }

        public static int GetNextSequence(string name)
        {


            var filter = Builders<BsonDocument>.Filter.Eq("_id", name);
            var update = Builders<BsonDocument>.Update.Inc("seq", 1);
            var options = new FindOneAndUpdateOptions<BsonDocument>
            {
                IsUpsert = true,
                ReturnDocument = ReturnDocument.After
            };

            var result = counterCollection.FindOneAndUpdate(filter, update, options);
            return result["seq"].AsInt32;
        }


        //----------------------------------------------------------------------------
        //-----------------------------Medicine---------------------------------------
        //----------------------------------------------------------------------------

        public static void AddMedicine(BsonDocument medicine)

        {
            medicineCollection.InsertOne(medicine);
        }

        public static List<BsonDocument> GetAllMedicines()
        {
            return medicineCollection.Find(new BsonDocument()).ToList();
        }

        public static bool MedicineExists(string name)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Name", name);
            return medicineCollection.Find(filter).Any();
        }

        public static DataTable ViewMedicineDetails()
        {
            var table = new DataTable();
            table.Columns.Add("MedicineID");
            table.Columns.Add("Name");
            table.Columns.Add("Type");
            table.Columns.Add("Manufacturer");
            table.Columns.Add("ExpiryDate");
            table.Columns.Add("Quantity");

            var collection = db.GetCollection<BsonDocument>("Medicine");

            // Sort medicines by MedicineID (ascending)
            var sort = Builders<BsonDocument>.Sort.Ascending("MedicineID");
            var docs = collection.Find(new BsonDocument()).Sort(sort).ToList();

            foreach (var doc in docs)
            {
                table.Rows.Add(
                    doc.GetValue("MedicineID", 0).ToInt32(),
                    doc.GetValue("Name", "").AsString,
                    doc.GetValue("Type", "").AsString,
                    doc.GetValue("Manufacturer", "").AsString,
                    doc.GetValue("ExpiryDate", BsonNull.Value).ToLocalTime().ToString("yyyy-MM-dd"),
                    doc.GetValue("Quantity", 0).ToInt32()
                );
            }

            return table;
        }

        public static bool DeleteMedicine(string id)
        {
            var collection = db.GetCollection<BsonDocument>("Medicine");
            var filter = Builders<BsonDocument>.Filter.Eq("MedicineID", int.Parse(id));
            var result = collection.DeleteOne(filter);
            return result.DeletedCount > 0;
        }



        public static List<string> GetAllPatients1()
        {
            var collection = db.GetCollection<BsonDocument>("Patient");
            return collection.Find(new BsonDocument())
                             .ToList()
                             .Select(p => p["Name"].AsString)
                             .ToList();
        }

        public static List<string> GetAllMedicines1()
        {
            var list = new List<string>();
            var medicines = db.GetCollection<BsonDocument>("Medicine").Find(new BsonDocument()).ToList();
            foreach (var med in medicines)
            {
                list.Add(med.GetValue("Name", "").AsString);
            }
            return list;
        }
        public static string IssueMedicine(string patientId, string medicineName, int quantity, double amount)
        {
            var medicineCollection = db.GetCollection<BsonDocument>("Medicine");
            var medFilter = Builders<BsonDocument>.Filter.Eq("Name", medicineName);
            var medicine = medicineCollection.Find(medFilter).FirstOrDefault();

            if (medicine == null)
                return "Medicine not found.";

            int availableQty = medicine.GetValue("Quantity", 0).ToInt32();
            if (availableQty < quantity)
                return "Not enough stock available.";

            // Reduce medicine quantity
            var update = Builders<BsonDocument>.Update.Inc("Quantity", -quantity);
            medicineCollection.UpdateOne(medFilter, update);

            // Insert issued medicine log
            var issueCollection = db.GetCollection<BsonDocument>("IssuedMedicines");
            var doc = new BsonDocument
    {
        { "PatientID", patientId },
        { "MedicineName", medicineName },
        { "Quantity", quantity },
        { "Amount", amount },
        { "IssuedDate", DateTime.Now }
    };
            issueCollection.InsertOne(doc);

            return "Medicine issued successfully.";
        }

        public static Dictionary<string, string> GetPatientNamesWithIds()
        {
            var dict = new Dictionary<string, string>();
            var patients = db.GetCollection<BsonDocument>("Patient").Find(new BsonDocument()).ToList();
            foreach (var p in patients)
            {
                string name = p.GetValue("Name", "").AsString;
                string id = p.GetValue("PatientID", "").ToString();
                if (!dict.ContainsKey(name))
                    dict[name] = id;
            }
            return dict;
        }


    }

}

