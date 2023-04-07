using System.Runtime.InteropServices.WindowsRuntime;

public class MedicalBot
{
    public const string botName = "Bob";

    public string GetBotName()
    {
        return botName;
    }

    public string PrescribeMedication(Patient patient)
    {
        string medicine;

        if (patient.GetSymptomCode() == "Headache")
        {
            medicine = "ibuprofen";
        }
        else if(patient.GetSymptomCode() == "Skin rashes")
        {
            medicine = "diphenhydramine";
        }
        else
        {
            medicine = patient.GetMedicalHisory() == "diabetes" ? "meltformin" : "dimenhydrinate";
        }

        string dozage;

        // local finction
        string GetDosage(string medicineName)
        {
            int recomendedDozage;
            int age = patient.GetAge();

            if (medicineName == "ibuprofen")
            {
                recomendedDozage = age < 18 ? 400 : 800;
            }
            else if (medicineName == "diphenhydramine")
            {
                recomendedDozage = age < 18 ? 50 : 300;
            } 
            else recomendedDozage = 500;

            return recomendedDozage + " mg";
        }

        dozage = GetDosage(medicine);


        return medicine + " " + dozage;
    }




}

public class Patient
{
    string name;
    int age;
    string gender;
    string medicalHistory;
    string symptomCode;
    string prescription;

    // getter: name
    public string GetName()
    {
        return name;
    }

    // setter: name
    public bool SetName(string name, out string errorMessage)
    {
        if(name == null || name == "")
        {
            errorMessage = "The name should not be null or empty";
            return false;
        } else if (name.Length < 2)
        {
            errorMessage = "Patient name should contain at least two or more characters.";
            return false;
        }

        this.name = name;
        errorMessage = "👍👍";
        return true;
    }


    // getter: age
    public int GetAge()
    {
        return age;
    }

    // setter: age
    public bool SetAge(int age, out string errorMessage)
    {
        if (age < 0)
        {
            errorMessage = "Patient age can't be negative";
            return false;
        } 
        else if(age > 100)
        {
            errorMessage = "Patient age can't be greater than 100";
            return false;
        }
        errorMessage = "👍👍";
        this.age = age;
        return true;
        
    }

    // getter: gender
    public string GetGender()
    {
        return gender;
    }

    // setter: gender
    public bool SetGender(string gender, out string errorMessage)
    {
        if(gender != "Male" && gender != "Female" && gender != "Other")
        {
            errorMessage = "Patient gender should be either Male, Female or Other";
            return false;
        }
        errorMessage = "👍👍";
        this.gender = gender;
        return true;
    }

    // getter: medicalHistory
    public string GetMedicalHisory()
    {
        return medicalHistory;
    }

    // setter: medical History
    public void SetMedicalHistory(string value = "")
    {
        medicalHistory = value;
    }

    // getter: symptomCode
    public string GetSymptomCode()
    {
        if (symptomCode == "S1")
        {
            return "Headache";
        }
        else if (symptomCode == "S2")
        {
            return "Skin Rashes";
        }
        else if (symptomCode == "S3")
        {
            return "Dizziness";
        }
        else return "Unknown";
    }

    // setter: symptomCode
    public bool SetSymptomCode(string value, out string errorMessage)
    {
        if(value != "S1" && value != "S2" && value != "S3")
        {
            errorMessage = "Symptom Code should either be S1, S2, or S3.";
            return false;
        }
        errorMessage = "👍👍";
        symptomCode = value;
        return true;
    }

    // getter: prescription
    public string GetPrescription()
    {
        return medicalHistory;
    }

    // setter: prescription
    public void SetPrescription(string value)
    {
        prescription = value;
    }
}