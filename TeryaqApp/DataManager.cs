using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teryaq
{
    internal static class DataManager
    {
        //Medcine List (Array)
        public static string[] medList = new string[50];

        public static void loadMedList()
        {
            try
            {

                if (File.Exists("MedsList.txt"))
                {
                    medList = File.ReadAllLines("MedsList.txt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading medicine list: " + ex.Message);
            }
        }

        //lists
        public static List<Person>
        allPeople = new List<Person>();

        public static List<Medicine>
        allMedicines = new List<Medicine>();

        //file paths
        private static string peopleFilePath = "people.txt";
        private static string medsFilePath = "medicines.txt";

        //Method of loading data from files
        public static void LoadData()
        {
            // Load people data
            try
            {
                if (File.Exists(peopleFilePath))
                {
                    var peopleLines = File.ReadAllLines(peopleFilePath);
                    foreach (var line in peopleLines)
                    {
                        var parts = line.Split(',');
                        if (parts.Length == 6)
                        {
                            string email = parts[0];
                            string name = parts[1];
                            string phonenumber = parts[2];
                            Governorate governorate = (Governorate) Enum.Parse(typeof(Governorate), parts[3]);
                            string password = parts[4];
                            Role role = (Role) Enum.Parse(typeof(Role), parts[5]);

                            Person person;
                            if (role == Role.Admin)
                            { person = new Admin(email, name, phonenumber, governorate, password); }
                            else
                            { person = new User(email, name, phonenumber, governorate, password, role); }

                            allPeople.Add(person);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading people data: " + ex.Message);
            }

            //Load Medicine data
            try
            {
                if (File.Exists(medsFilePath))
                {
                    var medLines = File.ReadAllLines(medsFilePath);
                    foreach (var line in medLines)
                    {
                        var parts = line.Split(',');
                        if (parts.Length == 5)
                        {
                            string medName = parts[0];
                            int qty = int.Parse(parts[1]);
                            MedicineType medtype = (MedicineType) Enum.Parse(typeof(MedicineType), parts[2]);
                            DateTime expiry = DateTime.Parse(parts[3]);
                            bool isapproved = bool.Parse(parts[4]);

                            Medicine med = new Medicine(medName, medtype, expiry, qty, isapproved);
                            allMedicines.Add(med);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading medicines data: " + ex.Message);
            }
        }

        //Method of Save Data
        public static void SaveData()
        {
            try
            {
                //Save Users
                List<string> peopleLines = new List<string>(); //بنحول الكائن لنص عشان يفهمه الفايل   //Temporary List
                foreach (var p in allPeople)
                {
                    string line = $"{p.Email}, {p.Name}, {p.PhoneNumber},{p.Governorate},{p.Password},{p.Role} ";
                    peopleLines.Add(line);
                }

                File.WriteAllLines(peopleFilePath, peopleLines);

                //Save Medicines
                List<string> medLines = new List<string>();
                foreach (var m in allMedicines)
                {
                    string line = $"{m.MedName}, {m.MedType}, {m.ExpiryDate},{m.Quantity},{m.IsApproved}";
                    medLines.Add(line);
                }

                File.WriteAllLines(medsFilePath, medLines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);

            }
        }

        //Donate & Request & Search

        //Method of Donate
        public static void DonateMedicine(Medicine newMed)
        {
            newMed.IsApproved = false; // New donations need admin approval
            allMedicines.Add(newMed);
            SaveData();
            MessageBox.Show("Thank you for your donation! Your medicine will be reviewed by our team and added to the inventory if approved.");
        }

        //Method of search
        public static List<Medicine> SearchMedicines(string name)
        {
            List<Medicine> results = new List<Medicine>();
            foreach (var med in allMedicines)
            {
                if (med.MedName.ToLower().Contains(name.ToLower()) && med.IsApproved)
                { results.Add(med); }
            }
            return results;
        }

        //Method of Request
        public static void RequestMedicine(Medicine selectedMed, int reqestedAmount)
        {
            selectedMed.Quantity -= reqestedAmount;

            if (selectedMed.Quantity <= 0)
            {
                allMedicines.Remove(selectedMed);
            }

            SaveData();
            MessageBox.Show("Your Order has been processed succssfully!");
        }

        //Methods for Admin

        //Method of pending medicines
        public static List<Medicine> PendingMedicines()
        {
            List<Medicine> pendingMeds = new List<Medicine>();
            foreach (var med in allMedicines)
            {
                if (!med.IsApproved)
                { pendingMeds.Add(med); }
            }
            return pendingMeds;
        }

        //Method of Expired Medicines
        public static List<Medicine> ExpiredMedicines()
        {
            List<Medicine> expiredMeds = new List<Medicine>();
            foreach (var med in allMedicines)
            {
                if (med.ExpiryDate <= DateTime.Now)
                { expiredMeds.Add(med); }
            }
            return expiredMeds;
        }

        //Method to Approve Medicine
        public static void ApproveMedicine(Medicine med, string finalName)
        {
            med.MedName = finalName;            // Update the medicine name with the final name provided by the admin
            med.IsApproved = true;

            SaveData();
            MessageBox.Show("Medicine has been approved and is now visible to users.");
        }

        //Method to Delete Medicine
        public static void DeleteMedicine(Medicine med)
        {
            allMedicines.Remove(med);
            SaveData();
            MessageBox.Show("Medicine has been deleted successfully.");

        }

        //Method to Convert List to Array
        public static T[] ConvertListToArray<T>(List<T> anyList)
        {
            
            if (anyList == null)
            {
                return new T[0]; 
            }

            return anyList.ToArray();
        }
    }
}