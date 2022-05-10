using System;
using System.Collections.Generic;

namespace Exam
{
    public class Program
    {
        private static Dictionary<string, Medicine> medicines = new Dictionary<string, Medicine>();
        private static Dictionary<string, Pharmacy> pharmacies = new Dictionary<string, Pharmacy>();

        static void Main()
        {
            string command = "";
            do
            {
                string[] splittedInput = Console.ReadLine().Split(' ');
                command = splittedInput[0];
                switch (splittedInput[0])
                {
                    case "AddMedicine":
                        AddMedicine(splittedInput[1], decimal.Parse(splittedInput[2]));
                        break;
                    case "StoreInfo":
                        MedicineInfo(splittedInput[1]);
                        break;
                    case "CreatePharmacy":
                        CreatePharmacy(splittedInput[1]);
                        break;
                    case "RenamePharmacy":
                        RenamePharmacy(splittedInput[1], splittedInput[2]);
                        break;
                    case "SellAllMedicines":
                        SellAllMedicines(splittedInput[1]);
                        break;
                    case "PharmacyInfo":
                        PharmacyInfo(splittedInput[1]);
                        break;
                    case "GetCarWithHighestPrice":
                        GetMedicineWithHighestPrice(splittedInput[1]);
                        break;
                    case "GetCarWithLowestPrice":
                        GetMedicineWithLowestPrice(splittedInput[1]);
                        break;
                    case "CalculateTotalPrice":
                        CalculateTotalPrice(splittedInput[1]);
                        break;
                }
            } while (command != "End");
        }

        private static void CalculateTotalPrice(string name)
        {
            try
            {
                if (!pharmacies.ContainsKey(name))
                {
                    Console.WriteLine("Could not calculate total price.");
                    return;
                }
                Pharmacy pharmacy = pharmacies[name];
                Console.WriteLine($"Total price: {pharmacy.CalculateTotalPrice():F2}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AddMedicine(string name, decimal price)
        {
            try
            {
                medicines.Add(name, new Medicine(name, price));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void MedicineInfo(string name)
        {
            if (!medicines.ContainsKey(name))
            {
                Console.WriteLine($"Could not get medicine {name}.");
                return;
            }
            Medicine store = medicines[name];
            Console.WriteLine(store.ToString());
        }

        private static void CreatePharmacy(string name)
        {
            try
            {
                Pharmacy pharmacy = new Pharmacy(name);
                pharmacies.Add(name, pharmacy);
                Console.WriteLine($"You created pharmacy {name}.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void PharmacyInfo(string name)
        {
            if (!pharmacies.ContainsKey(name))
            {
                Console.WriteLine($"Could not get pharmacy {name}.");
                return;
            }
            Pharmacy pharmacy = pharmacies[name];
            Console.WriteLine(pharmacy.ToString());
        }

        private static void RenamePharmacy(string name, string newName)
        {
            if (!pharmacies.ContainsKey(name))
            {
                Console.WriteLine($"Could not rename the pharmacy {name}.");
                return;
            }
            Pharmacy pharmacy = pharmacies[name];
            try
            {
                pharmacy.RenamePharmacy(newName);
                pharmacies.Remove(name);
                pharmacies.Add(newName, pharmacy);
                Console.WriteLine($"You renamed your pharmacy from {name} to {newName}.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void SellAllMedicines(string name)
        {
            if (!pharmacies.ContainsKey(name))
            {
                Console.WriteLine($"Could not sell all medicines {name}.");
                return;
            }
            Pharmacy pharmacy = pharmacies[name];
            pharmacy.SellAllMedicines();
            Console.WriteLine($"You sold all cars from pharmacy {name}.");
        }

        private static void GetMedicineWithLowestPrice(string name)
        {
            if (!pharmacies.ContainsKey(name))
            {
                Console.WriteLine($"Could not get car with lowest price from pharmacy {name}.");
                return;
            }
            Pharmacy pharmacy = pharmacies[name];
            Console.WriteLine($"Car from store {name} has lowest price: {pharmacy.GetMedicineWithLowestPrice().Price:F2}");
        }
        private static void GetMedicineWithHighestPrice(string name)
        {
            if (!pharmacies.ContainsKey(name))
            {
                Console.WriteLine($"Could not get car with highest price from pharmacy {name}.");
                return;
            }
            Pharmacy pharmacy = pharmacies[name];
            Console.WriteLine($"Car from store {name} has highest price: {pharmacy.GetMedicineWithHighestPrice().Price:F2}");
        }
    }
}