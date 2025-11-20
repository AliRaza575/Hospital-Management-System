using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SignInSignUpApplication_WindowsForm_
{
    internal class BL
    {

        public static string SignIn(string username, string password) =>
            DL.GetUserID(username, password);

        public static string GetUserRole(string userID) =>
            DL.GetUserRole(userID);

        public static void Register(string username, string password, string role)
        {
            if (role != "Admin")
                throw new ArgumentException("Only Admin role is allowed.");

            var user = new BsonDocument
    {
        { "UserId", Guid.NewGuid().ToString() },
        { "Username", username },
        { "Password", password },
        { "Role", role }
    };
            DL.AddUser(user);
        }


    }

    internal static class AdminBL
    {
        public static DataTable ViewDoctors() =>
            DL.ViewDoctorDetails();
        public static void AddBill(string patientId, int bill)
        {
            var billDoc = new BsonDocument
    {
        { "PatientID", patientId },
        { "BillAmount", bill },
        { "Date", DateTime.Now }
    };
            DL.FetchPatientBills(patientId);
        }

        public static void DeleteUser(string userId, bool flag)
        {
            if (flag)
            {
                DL.DeleteDoctor(userId);
            }
            else
            {
                DL.DeletePatient(userId);
            }
        }
        public static void DeletePatient(string userId, bool isDoctor)
        {
            if (isDoctor)
                DL.DeleteDoctor(userId); // Assume this is implemented
            else
                DL.DeletePatient(userId);
        }
        public static void DeleteDoc(string userId, bool isDoctor)
        {
            if (isDoctor)
                DL.DeleteDoctor(userId);
            else
                DL.DeletePatient(userId);
        }

      
     





        //  public static void DeleteDoctor(string id) => DL.DeleteDoctor(id);
        // public static void DeletePatient(string id) => DL.DeletePatient(id);
    }

    internal static class BillBL
    {
        public static void AddBill(string patientId, int billAmount, string date)
        {
            if (DL.IsBillAlreadyIssued(patientId, date))
            {
                MessageBox.Show("Bill has already been issued to this patient for the selected date!",
                                "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int nextBillId = DL.GetNextBillId();

                var bill = new BsonDocument
            {
                { "BillID", nextBillId },
                { "PatientID", patientId },
                { "Amount", billAmount },
                { "Date", date }
            };

                DL.AddBill(bill);

                MessageBox.Show("Bill added successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static DataTable ViewBill()
        {
            return DL.ViewBill();
        }

        public static bool DeleteBill(string billId)
        {
            return DL.DeleteBill(billId);
        }
        // BL.cs
        // BL.cs
        public static (double TotalAmount, double? RoomChargePerDay, DateTime? DischargeDate, bool IsRoomAllocated, double MedicineCharge) GenerateFinalBill(string patientId)
        {
            return DL.CalculateTotalBill(patientId);
        }

    }
    internal static class salaryBL
    {
        public static void AddSalary(string doctorId, int salaryAmount, string Date)
        {
            if (DL.IsSalaryAlreadyIssued(doctorId, Date))
            {
                MessageBox.Show("Salary has already been issued to this doctor for the selected date!",
                                "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int nextSalaryId = DL.GetNextSalaryId();

                var salary = new BsonDocument
        {
            { "SalaryID", nextSalaryId },
            { "DoctorID", doctorId },
            { "Salary", salaryAmount },
            { "Date", Date }
        };

                DL.AddSalary(salary);

                MessageBox.Show("Salary added successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static DataTable viewsalary()
        {
            return DL.ViewSalary();
        }

        public static bool DeleteSalary(string salaryId)
        {
            return DL.DeleteSalary(salaryId); // Delegate to Data Layer
        }

    }

    internal static class DoctorBL
    {
        public static void AddDoctor(string name, int age, string specialization, string experience, int fees)
        {
            int id = DL.GetNextDoctorID();  // Auto-generated ID

            var doctor = new BsonDocument
    {
        { "DoctorID", id },
        { "Name", name },
        { "Age", age },
        { "Specialization", specialization },
        { "Experience", experience },
        { "Fees", fees }
    };

            DL.AddDoctor(doctor);
        }

        public static DataTable ViewDoctors()
        {
            return DL.ViewDoctorDetails();
        }

       
        public static void AddSalary(string doctorId, int salary)
        {
            DL.AddDoctorSalary(doctorId, salary);
        }
        public static void UpdateDoctorDetails(int id, string name, int age, string specialization, string experience, int fees)
        {
            DL.UpdateDoctorInDatabase(id, name, age, specialization, experience, fees);
        }

        public static DataTable GetAppointments(string userId)
        {
            return DL.GetAppointmentsForDoctor(userId);
        }
        public static void DeleteDoctor(string id)
        {
            bool exists = DL.DoctorExists(id);
            if (exists)
            {
                DL.DeleteDoctor(id);
                MessageBox.Show("Doctor deleted successfully.");
            }
            else
            {
                MessageBox.Show("Doctor with this ID does not exist.");
            }
        }
        public static DataTable ViewDoctor(bool flag, string userId)
        {
            if (flag)
                return DL.ViewDoctorDetails(); // All doctors
            else
                return DL.ViewDoctorById(userId); // Single doctor
        }
        public static DataTable GetDoctorSalary(string doctorId)
        {
            return DL.FetchDoctorSalary(doctorId);
        }
    }

    internal static class PatientBL
    {

        public static DataTable GetPatientBills(string patientId)
        {
            return DL.FetchPatientBills(patientId);
        }
        public static DataTable ViewPatient(bool flag, string userId)
            {
            if (flag)
                return DL.ViewPatientDetails();
            else
                return DL.ViewPatientById(userId);
        }


        public static void AddPatient(string name, int age, string gender, int height, int weight)
        {
            string id = DL.GetNextPatientID(); // Now string formatted ID

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



        public static void UpdatePatient(string id, string name, int age, string gender, int height, int weight)
        {
            bool exists = DL.PatientExists(id);

            if (exists)
            {
                DL.UpdatePatient(id, name, age, gender, height, weight);
                MessageBox.Show("Patient updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Patient with this ID does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void DeletePatient(string id)
        {
            bool exists = DL.PatientExists(id);

            if (exists)
            {
                DL.DeletePatient(id);
                MessageBox.Show("Patient deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No patient found with this ID!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public static void AddAppointment(string patientId, string doctorId)
        {
            var appointment = new BsonDocument
            {
                { "PatientID", patientId },
                { "DoctorID", doctorId }
            };
            DL.AddAppointment(appointment);
        }
        public static DataTable GetAvailableDoctors()
        {
            return DL.FetchDoctorList();
        }

        public static void BookAppointment(string patientId, string doctorId)
        {
            DL.AddAppointment(patientId, doctorId);
        }

    }

    public static class RoomBL
    {
        public static void AddRoom(string type, int charges, string availability)
        {
            // Auto-generate next RoomID
            int seq = DL.GetNextRoomSequence();
            string id = "R" + seq.ToString("D3"); // Format: R001, R002, ...

            var room = new BsonDocument
    {
        { "RoomID", id },
        { "RoomType", type },
        { "ChargesPerDay", charges },
        { "Availability", availability }
    };

            bool exists = DL.RoomExists(id);
            if (exists)
            {
                MessageBox.Show("A room with this ID already exists!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DL.AddRoom(room);
                MessageBox.Show($"Room added successfully! RoomID: {id}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        public static string AllocateRoomToPatient(string patientId, string roomId, DateTime allocationDate, DateTime dischargeDate)
        {
            if (!DL.PatientExists(patientId))
                return "Patient ID does not exist in records.";

            if (DL.IsPatientAlreadyAssignedRoom(patientId))
                return "This patient is already assigned a room.";

            string roomAvailability = DL.GetRoomAvailability(roomId);
            if (!roomAvailability.Trim().Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                return "This room is already occupied.";
            }

            try
            {
                DL.AddRoomAllocation(patientId, roomId, allocationDate, dischargeDate);
                DL.UpdateRoomAvailability(roomId, "No");
                return "Room successfully allocated to the patient.";
            }
            catch (Exception ex)
            {
                return "Error while allocating room: " + ex.Message;
            }
        }


        public static string RemoveRoomAllocationForPatient(string patientId)
        {
            return DL.RemoveRoomAllocation(patientId);
        }

        public static DataTable GetRoomDataTable()
        {
            return DL.ViewRoomDetails();
        }
    }
    public static class MedicineBL
    {
        public static string AddMedicine(string name, string type, string manufacturer, DateTime expiryDate, int quantity)
        {
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(type) ||
                string.IsNullOrWhiteSpace(manufacturer) ||
                quantity < 0)
            {
                return "All fields are required and quantity must be non-negative.";
            }

            if (DL.MedicineExists(name))
            {
                return "Medicine with the same name already exists.";
            }

            if (expiryDate <= DateTime.Now)
            {
                return "Expiry date must be in the future.";
            }

            int nextId = DL.GetNextSequence("MedicineID");

            BsonDocument medicine = new BsonDocument
    {
        { "MedicineID", nextId },
        { "Name", name },
        { "Type", type },
        { "Manufacturer", manufacturer },
        { "ExpiryDate", expiryDate },
        { "Quantity", quantity }
    };

            DL.AddMedicine(medicine);
            return "Medicine added successfully.";
        }
        public static DataTable GetMedicineDataTable()
        {
            return DL.ViewMedicineDetails();
        }
        public static string DeleteMedicine(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return "Invalid Medicine ID.";

            bool deleted = DL.DeleteMedicine(id);
            return deleted ? "Medicine deleted successfully!" : "Medicine not found.";
        }

        public static List<string> GetPatientNames()
        {
            return DL.GetAllPatients1();
        }

        public static List<string> GetMedicineNames()
        {
            return DL.GetAllMedicines1();
        }

        public static string IssueMedicine(string patientId, string medicineName, int quantity, double amount)
        {
            if (string.IsNullOrWhiteSpace(patientId) || string.IsNullOrWhiteSpace(medicineName) || quantity <= 0 || amount < 0)
                return "Invalid input provided.";

            return DL.IssueMedicine(patientId, medicineName, quantity, amount);
        }

        public static Dictionary<string, string> GetPatientNameIdMap()
        {
            return DL.GetPatientNamesWithIds();
        }

    }
}
