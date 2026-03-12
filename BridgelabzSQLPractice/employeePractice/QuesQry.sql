-- 2nd hihgest salry

Select empID,empName,Salary 
from Employee
Order by Salary desc
Offset 1 Rows
Fetch Next 1 Rows Only;

-- emps having salary greater dept avg

Select empID,empName,Salary
from Employee
where Salary >(Select avg(Salary) from Employee where Dept=Employee.Dept);

-- update any column
Alter Table Employee
Add Constraint CHK_Dept
Check (Dept IN  ('IT','HR','Finance'));

-- emp with highest exp
Select empid,empName,Joindate
From Employee
Where Joindate = (Select min(JoinDate) from Employee);

-- emps with 2 "S" in name
Select empName
From Employee
Where empName like '%S%S%';

--
Select dept ,salary
from Employee
Where Salary > (Select avg(Salary)
from Employee where Dept=Employee.Dept);

-- avg salary of dept grater than avg salary
Select dept , avg(salary) as AvgSalary
from Employee
Group by dept Having avg(Salary) > (Select avg(Salary) from Employee);




