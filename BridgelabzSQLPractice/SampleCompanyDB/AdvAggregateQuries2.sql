--q26 Locations with avg sal > salgrade 3 high
select * from emp;
select * from dept;
select * from salgrade;
select * from bonus;

select loc 
from dept d
join emp e on d.deptno = e.deptno
Group by d.loc Having Avg(e.sal)> 
(Select hisal  From salgrade where grade = 3 
Order by hisal Offset 1 Rows);

--q27 27. Dept subtotals with ROLLUP

Select d.dname, Sum(sal) as total_salary
From dept d join emp e on d.deptno = e.deptno
Group by ROLLUP(d.dname);

--q28  Jobs with variance in salary >500.
Select job,Var(sal) as salary_variance
from emp
Group by job
Having var(sal) > 500;

SELECT job FROM emp GROUP BY job HAVING MAX(sal) - MIN(sal) > 500;

--q29
select d.dname,Year(e.hiredate) as HireYear,sal
from dept d
join emp e on d.deptno = e.deptno
Group by d.dname,e.hiredate,e.sal
Having Year(e.hiredate) > 1981 AND e.sal > 2000;

--q30

Select mgr,sal
from emp 
Group by mgr,sal
Having sal>1500;

SELECT m.ename
FROM emp m 
JOIN emp e ON m.empno = e.mgr 
GROUP BY m.empno, m.ename 
HAVING COUNT(e.empno) > 2 AND AVG(e.sal) > 1500;



