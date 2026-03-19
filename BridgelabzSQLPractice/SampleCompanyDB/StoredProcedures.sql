-- stored procedues
use SampleCompanyDB
--simple 

Create or Alter Procedure GetEmployeeById
	@EmpNo int 
As
Begin
	Select empno,ename,job
	from emp
	where empno = @EmpNo
End
Go

Execute GetEmployeeById @EmpNo = 7369;

-- o/p param + error handling

Create or alter procedure UpdateSalaryWithCheck
	@Empno int,
	@Newsalary decimal(10,2),
	@Rowsaffected int output
As
Begin
	Set Nocount on;
	Begin try
		Begin Transaction;
		If not exists(Select 1 from emp Where empno = @Empno)
			Throw 50001, 'Employee not found', 1;

		Update emp
		Set sal = @Newsalary
		where empno = @Empno;

		Set @Rowsaffected = @@rowcount;

		Commit Transaction;
	End try
	Begin catch
		If @@TRANCOUNT > 0 Rollback Transaction;
		Throw;
	End catch
End 
GO

Execute UpdateSalaryWithCheck @Empno = 7369, @Newsalary = 5000, @Rowsaffected = 1 ;
Select * from emp
Where empno = 7369;


-- report - department salary summary

Create or alter Procedure GetDepartmentSalarySummary
As
Begin
	Select 
		d.dname,
		Count(e.empno) total_emps,
		Sum(e.sal) salary_sum,
		Avg(e.sal) salary_avg
		From dept d
		join emp e on d.deptno = e.deptno
		Group By d.dname;
End 
Go

Execute GetDepartmentSalarySummary;

EXEC sp_helptext 'dbo.GetEmployeeById';

EXEC sp_help 'emp';