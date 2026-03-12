select * from emp;
select * from dept;
select * from salgrade;

--q31

select e.ename,d.dname,d.loc
from emp e
join dept d on e.deptno = d.deptno;

--q32

SELECT e.ename employee, m.ename manager 
FROM emp e INNER JOIN emp m
ON e.mgr = m.empno;

--q33

select d.dname , count(e.empno) as count
from dept d
join emp e on d.deptno = e.deptno
Group by dname;

--q34

select  distinct e.ename,s.grade,e.sal
from emp e 
join salgrade s on e.sal between s.losal and s.hisal
Order by s.grade;

--q35
Select ename
from emp
where mgr = 
(Select empno 
from emp
where ename = 'KING');

WITH hierarchy AS (SELECT empno, ename, mgr, 
CAST(ename AS VARCHAR(100)) path 
FROM emp 
WHERE empno = 7839 UNION ALL --anchor
SELECT e.empno,e.ename, e.mgr, CAST(h.path + ' > ' + e.ename AS VARCHAR(100))
FROM emp e JOIN hierarchy h ON e.mgr = h.empno) 
SELECT * FROM hierarchy;

--q36
select count(*)
from emp e
cross join dept d where e.deptno = d.deptno;

SELECT * FROM emp e1 CROSS JOIN emp e2 WHERE e1.job = e2.job;

--q37
select * from EMP;
SELECT * from salgrade;

select distinct e.ename,e.sal, s.grade
from emp e
right join salgrade s on e.sal between s.losal and s.hisal
Order by s.grade;

SELECT s.grade, COUNT(e.empno) emp_count FROM salgrade s RIGHT JOIN
emp e ON e.sal BETWEEN s.losal AND s.hisal GROUP BY s.grade;

--q38

