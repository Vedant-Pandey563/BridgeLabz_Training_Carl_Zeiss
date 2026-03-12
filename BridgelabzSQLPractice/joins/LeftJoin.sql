Select Employee.Empid, Employee.EmpName, Department.DepartmentName

From Employee
Left Join Department
On Employee.DepartmentID = Department.DepartmentID;