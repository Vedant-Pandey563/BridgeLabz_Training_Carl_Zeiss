Create Table Employee 
(
	EmpID int IDENTITY(1,1) PRIMARY KEY,
	EmpName varchar(255) not null,
	Salary int not null Check(Salary>0),
	JoinDate date not null default(Current_Date),
	Dept varchar(255) not null,
);

Select * from Employee;
