Select Employee.Empid, Employee.EmpName, Department.DepartmentName,Department.DepartmentID
From Employee
Right Join Department
on Employee.DepartmentID = Department.DepartmentID;

Select * From Employee;
Select * From Department;
	