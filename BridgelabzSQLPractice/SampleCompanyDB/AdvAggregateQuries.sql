Use SampleCompanyDB;

--q21

select job , Count(*) as job_count
from emp
Group by job Having Count(*) > 2; 

--q22

select dname , total_salary = Sum(sal)
from dept d
Left join emp e on d.deptno = e.deptno
Group by dname Having Sum(sal) > 5000;

--q23

Select m.ename,Avg(e.sal) as avg_salary
from emp m join emp e
on m.empno = e.mgr
group by m.empno,m.ename Having Avg(e.sal)>2000;

--q24

select * from emp;
select * from dept;

select dname 
from dept d 
join emp e on d.deptno = e.deptno
where e.job = 'Clerk'
Group by d.dname Having Count(*) > 1;

--q25

select * from emp;
Select job
from emp
Group by job Having Max(sal) > 2500 ;



