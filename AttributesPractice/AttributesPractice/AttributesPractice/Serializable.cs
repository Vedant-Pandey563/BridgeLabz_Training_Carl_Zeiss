//using System;
//using System.Collections.Generic;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Text;

//namespace AttributesPractice
//{
//    [Serializable]
//    class Employee
//    {
//        public string Name;
//        public int Id;
//    }
//    internal class Serializable
//    {
//        static void Main(string[] args)
//        {
//            Employee emp = new Employee();
//            emp.Id=1;
//            emp.Name = "A";

//            FileStream fs = new FileStream("emp.data", FileMode.OpenOrCreate);

//            BinaryFormatter formatter = new BinaryFormatter();

//            formatter.Serialize(fs, emp);

//            fs.Close();
//        }

//    }
//}
