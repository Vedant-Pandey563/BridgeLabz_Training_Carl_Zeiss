namespace EmployeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContractEmployee employee =  new ContractEmployee(
                    4,
                    "Captian",
                    "Cmail3@gmail.com",
                    "9876543212",
                    "SWE",
                    1000000,
                    12);
            employee.Display();
            //Console.WriteLine("Employee Management App");

            ////using try catch 
            try
            {

                // emp collection obj
                EmployeeCollections collect = new EmployeeCollections();

                Employee emp1 = new FullTimeEmployee(
                   1,
                   "Apple",
                   "ap1ple@gmail.com",
                   "9876543210",
                   "IT",
                   50000);

                Employee emp2 = new PartTimeEmployee(
                    2,
                    "Banana",
                    "2bananaMAIL@gmail.com",
                    "9876543211",
                    "HR",
                    500,
                    80);

                Employee emp3 = new ContractEmployee(
                    3,
                    "Coconut",
                    "Cmail3@gmail.com",
                    "9876543212",
                    "IT",
                    600000,
                    12);

                //adding emps
                collect.AddEmployee(emp1);
                collect.AddEmployee(emp2);
                collect.AddEmployee(emp3);

                Console.WriteLine("Dispaly All Employees");
                collect.DisplayAllEmployees();

                //wage calcs
                WageCalculation wage = new WageCalculation(collect);
                Console.WriteLine("Wage Calculations");

                wage.DisplaySalarySummary();


                // Department grouping test
                Console.WriteLine("IT Department Employees");

                var dept = collect.GetEmployeesByDepartment("IT");

                foreach (var emp in dept)
                {
                    emp.Display();
                }


                //search by id
                Console.WriteLine("Employee Search by id");

                EmployeeSearch EmpSearch = new EmployeeSearch(collect.GetAllEmployees());

                Console.WriteLine();

                Employee found = EmpSearch.SearchById(2);

                if (found != null)
                {
                    found.Display();
                }
                else
                {
                    Console.WriteLine("Employee not found");
                }

                Employee found2 = EmpSearch.SearchById(67);
                if (found2 != null)
                {
                    found2.Display();
                }
                else
                {
                    Console.WriteLine("Employee not found");
                }



                Employee emp4 = new ContractEmployee(
                    4,
                    "Captian",
                    "Cmail3@gmail.com",
                    "9876543212",
                    "SWE",
                    1000000,
                    12);

                List<Employee> employees = new List<Employee>();
                employees.Add(emp1);
                employees.Add(emp2);
                employees.Add(emp3);
                employees.Add(emp4);


                collect.AddEmployee(emp4);


                //duplicate email 
                string duplicateEmail = DuplicateDetect.FindDuplicateEmail(collect.GetAllEmployees());

                if (duplicateEmail != null)
                {
                    Console.WriteLine("Duplicate Email Found: " + duplicateEmail);
                }
                else
                {
                    Console.WriteLine("No duplicate email found.");
                }

                Console.WriteLine("Writing to new text file ");
                FileService fileService = new FileService("employees2.txt");

                fileService.SaveEmployees(employees);
                fileService.ReadEmployees();


            }
            catch (EmployeeExceptions ex) //custom excpetion
            {
                Console.WriteLine("Employee Custom Exception : " + ex.Message);
            }
            catch (Exception ex) //any other general excpetion
            {
                Console.WriteLine("General Excpetion : " + ex.Message);

            }


            Console.ReadLine();
        }
    }
}
