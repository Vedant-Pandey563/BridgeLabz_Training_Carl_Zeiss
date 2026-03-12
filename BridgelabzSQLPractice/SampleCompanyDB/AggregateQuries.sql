--q11

Select d.dname, COUNT(e.empno) 
From dept d
Left Join emp e on d.deptno = e.deptno
Group By d.dname;

--q12

Select AVG(sal) as average_salary
from emp;

--q13

Select job , Max(sal) as max_salary 
from emp
Group By job;

--q14

select loc, Sum(sal) as total_salary
from dept d
Left Join emp e on d.deptno = e.deptno
Group By loc;

--q15

select dname ,MIN(sal) as min_salary, Max(sal) as max_salary
from dept d
Left Join emp e on d.deptno = e.deptno
Group By dname;
