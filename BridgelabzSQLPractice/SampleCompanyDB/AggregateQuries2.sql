--q16

Select count(Distinct mgr) 
from emp
where mgr is not null;

--q17

Select Avg (comm)
from emp
where job = 'SALESMAN';

--q18

Select ename,total = sal + ISNULL(comm,0)
from emp;

--q19

Select dname
from dept d
Left Join emp e on d.deptno = e.deptno
Group By dname
Having AVG(sal) > 1500;

--q20
Select dname, Min(hiredate) as earliest_hiredate , MAX(hiredate) as latest_hiredate
from dept d
Left Join emp e on d.deptno = e.deptno
Group By dname;

