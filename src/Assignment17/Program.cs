using System;

class Program
{
    public static void Main()
    {
       MedicalBot bot = new MedicalBot();
       Patient patient = new Patient();

        Console.WriteLine("Hi, I'm " + bot.GetBotName() + ". I'm here to help you with your medication" );
        Console.WriteLine("Enter you (patient) details: ");
        Console.WriteLine("Enter Patiient Name:");

        string errorMessage = "";

        Console.WriteLine(errorMessage);

        while (errorMessage != "👍👍")
        {
            Console.WriteLine(errorMessage);
            patient.SetName(Console.ReadLine(), out errorMessage);
        }

        Console.WriteLine("Enter Patiient age:");
        
        errorMessage = "";
        while (errorMessage != "👍👍")
        {
            Console.WriteLine(errorMessage);
            patient.SetAge(int.Parse(Console.ReadLine()), out errorMessage);
        }        
        
        
        Console.WriteLine("Enter Patiient Gender:");
        
        errorMessage = "";
        while (errorMessage != "👍👍")
        {
            Console.WriteLine(errorMessage);
            patient.SetGender(Console.ReadLine(), out errorMessage);
        }        
        
        
        Console.WriteLine("Enter Medical History. Eg: Diabetes. Press Enter for None: Diabetes:");

        patient.SetMedicalHistory(Console.ReadLine());



        Console.WriteLine("Welcome, " + patient.GetName() + ", " + patient.GetAge());
        Console.WriteLine("which of the following symptoms do yo have:");
        Console.WriteLine("S1 Headache");
        Console.WriteLine("S2 Skin rashes");
        Console.WriteLine("S3 Dizzines");
        Console.WriteLine("Enter the symptom code from ther above list (S1, S2, S3): ");

        errorMessage = "";
        while (errorMessage != "👍👍")
        {
            Console.WriteLine(errorMessage);
            patient.SetSymptomCode(Console.ReadLine(), out errorMessage);
        }

        Console.WriteLine("Your prescription based on your age, symptoms and medical history:");
        Console.WriteLine("\n");
        Console.WriteLine(bot.PrescribeMedication(patient));
    }
}