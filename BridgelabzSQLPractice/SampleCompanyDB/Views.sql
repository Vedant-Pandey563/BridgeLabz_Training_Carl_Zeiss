-- views
Select * from emp;

Create view vw_EmployeeDetails
As 
Select empno,ename,sal
From emp
Where mgr is not null;

Select * from vw_EmployeeDetails;

Alter view vw_EmployeeDetails
AS
Select empno,ename,sal,deptno
from emp;

Select * from vw_EmployeeDetails;

-- complex view

Create view vw_deptsalary
as
select d.dname,avg(sal) as avg_sal
from dept d 
join emp e on d.deptno = e.deptno
group by d.dname;

select * from vw_deptsalary;

--indexded view

Alter view vw_emp_cnt
With Schemabinding
as
Select d.dname, Count_big(d.loc) as total_cnt
from dbo.dept d
group by dname;

select * from vw_emp_cnt;