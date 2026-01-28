namespace HealthCareRecord
{
    class MedicalRecord
    {
        public string PatientName;
        public int Age;
        public double PatientID;

        public MedicalRecord(string patientName, int age, double patientID)
        {
            this.PatientName = patientName;
            this.Age = age;
            this.PatientID = patientID;
        }

        public virtual void DisplaYPatientInfo()
        {
            Console.WriteLine($"Patient Name: {PatientName}");
            Console.WriteLine($"Patient Age: {Age}");
            Console.WriteLine($"Patient ID: {PatientID}");
            Console.WriteLine();
        }
    }

    class Presciption : MedicalRecord
    {
        public string MedicineName;
        public int DailyDose;

        public Presciption (string patientName, int age, double patientID, string medicineName, int dailyDose)
            : base(patientName, age, patientID)
        {
            this.MedicineName = medicineName;
            this.DailyDose = dailyDose;
        }

        public override void DisplaYPatientInfo()
        {
            Console.WriteLine($"Medicine Name: {MedicineName}");
            Console.WriteLine($"Daily Dose: {DailyDose}");
            Console.WriteLine();
        }
    }

    class LabReport : MedicalRecord
    {
        public string TestName;
        public bool Result;

        public LabReport(string patientName, int age,double patientID, string testname,bool result)
            :base(patientName,age,patientID)
        {
            this.TestName = testname;
            this.Result = result;
        }

        public override void DisplaYPatientInfo()
        {
            Console.WriteLine($"Test Name: {TestName}");
            Console.WriteLine($"Result: {Result}");
            Console.WriteLine();
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HealthCare Record");

            MedicalRecord record1 = new MedicalRecord("A", 45, 123456);
            record1.DisplaYPatientInfo();

            Presciption prescription1 = new Presciption("A",45,123456,"Crocin",3);
            prescription1.DisplaYPatientInfo();

            LabReport labReport1 = new LabReport("A",45,123456,"Diabetes", true);
            labReport1.DisplaYPatientInfo();
        }
    }
}
