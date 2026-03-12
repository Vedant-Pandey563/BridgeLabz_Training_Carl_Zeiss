-- single row subquery
select ename,sal
from emp
where sal> (Select sal 
From emp 
Where ename = 'Jones');

-- MULTI ROW SUBQUERY
Select ename
from emp
where deptno in (Select deptno from dept where dname = 'Research');

-- ANY op

Select ename,sal
from emp
where sal > any (Select sal from emp where deptno = 30);

-- ALL op
Select ename,sal
from emp
where sal > all (Select sal from emp where deptno = 30);

-- correlated subquery
Select ename,sal
from emp e
Where sal> (Select avg(sal) from emp where deptno = e.deptno);

--exists
Select dname
From dept d 
Where exists (Select * from emp e where e.deptno = d.deptno);


