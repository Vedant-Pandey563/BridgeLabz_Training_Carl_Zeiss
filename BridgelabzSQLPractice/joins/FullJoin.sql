Select Employee.Empid, Employee.EmpName, Employee.Salary, Department.DepartmentName,Department.DepartmentID
From Employee
Full Join Department
on Employee.DepartmentID = Department.DepartmentID;