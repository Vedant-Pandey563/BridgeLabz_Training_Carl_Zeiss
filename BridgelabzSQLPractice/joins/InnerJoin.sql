Select Employee.Empid, Employee.EmpName, Department.DepartmentName

From Employee
Inner Join Department
On Employee.DepartmentID = Department.DepartmentID;

Insert into Employee values (104, 'D', 55000,4);


Select * from Employee;
Select * from Department;