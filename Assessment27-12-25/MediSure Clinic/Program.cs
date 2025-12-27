using System;

namespace MediSureClinic;

class Program
{
    static PatientBill LastBill;
    static bool HasLastBill = false;

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n================== MediSure Clinic Billing ==================");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    CreateNewBill();
                    break;

                case 2:
                    ViewLastBill();
                    break;

                case 3:
                    ClearLastBill();
                    break;

                case 4:
                    Console.WriteLine("Thank you. Application closed normally.");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose between 1 and 4.");
                    break;
            }

        } while (choice != 4);
    }

    // 1) Create/Register Method
    public static void CreateNewBill()
    {
        PatientBill bill = new PatientBill();

        Console.Write("Enter Bill Id: ");
        bill.BillId = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(bill.BillId))
        {
            Console.WriteLine("Bill Id cannot be empty.");
            return;
        }

        Console.Write("Enter Patient Name: ");
        bill.PatientName = Console.ReadLine();

        Console.Write("Is the patient insured? (Y/N): ");
        char ins = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();
        bill.HasInsurance = (ins == 'Y');

        Console.Write("Enter Consultation Fee: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal consultFee) || consultFee <= 0)
        {
            Console.WriteLine("Consultation Fee must be greater than 0.");
            return;
        }
        bill.ConsultationFee = consultFee;

        Console.Write("Enter Lab Charges: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal lab) || lab < 0)
        {
            Console.WriteLine("Lab Charges cannot be negative.");
            return;
        }
        bill.LabCharges = lab;

        Console.Write("Enter Medicine Charges: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal med) || med < 0)
        {
            Console.WriteLine("Medicine Charges cannot be negative.");
            return;
        }
        bill.MedicineCharges = med;

        //Calculationing Bill
        bill.GrossAmount = bill.ConsultationFee + bill.LabCharges + bill.MedicineCharges;

        bill.DiscountAmount = bill.HasInsurance ? bill.GrossAmount * 0.10m : 0;

        bill.FinalPayable = bill.GrossAmount - bill.DiscountAmount;

        LastBill = bill;
        HasLastBill = true;

        Console.WriteLine("\nBill created successfully.");
        Console.WriteLine($"Gross Amount: {bill.GrossAmount:F2}");
        Console.WriteLine($"Discount Amount: {bill.DiscountAmount:F2}");
        Console.WriteLine($"Final Payable: {bill.FinalPayable:F2}");
        Console.WriteLine("------------------------------------------------------------");
    }

    // 2) View Method
    public static void ViewLastBill()
    {
        if (!HasLastBill)
        {
            Console.WriteLine("No bill available. Please create a new bill first.");
            return;
        }

        Console.WriteLine("\n----------- Last Bill -----------");
        Console.WriteLine($"BillId: {LastBill.BillId}");
        Console.WriteLine($"Patient: {LastBill.PatientName}");
        Console.WriteLine($"Insured: {(LastBill.HasInsurance ? "Yes" : "No")}");
        Console.WriteLine($"Consultation Fee: {LastBill.ConsultationFee:F2}");
        Console.WriteLine($"Lab Charges: {LastBill.LabCharges:F2}");
        Console.WriteLine($"Medicine Charges: {LastBill.MedicineCharges:F2}");
        Console.WriteLine($"Gross Amount: {LastBill.GrossAmount:F2}");
        Console.WriteLine($"Discount Amount: {LastBill.DiscountAmount:F2}");
        Console.WriteLine($"Final Payable: {LastBill.FinalPayable:F2}");
        Console.WriteLine("--------------------------------");
    }

    public static void ClearLastBill()
    {
        LastBill = null;
        HasLastBill = false;
        Console.WriteLine("Last bill cleared.");
    }
}