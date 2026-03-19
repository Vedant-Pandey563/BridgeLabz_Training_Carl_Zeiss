-- cte

--simple cte
with HighSalary as
(
	Select empno,ename,sal
	from emp
	where sal > 3000
)

select * from HighSalary;


With EmpDept as 
(
	Select e.ename,e.empno,d.dname
	from emp e
	join dept d
	on e.deptno = d.deptno
)
Select * from EmpDept;

-- 

WITH DeptAvg AS
(
SELECT deptno, AVG(sal) AS avg_sal
FROM emp
GROUP BY deptno
)

SELECT e.empno, e.ename, e.sal
FROM emp e
JOIN DeptAvg d
ON e.deptno = d.deptno
WHERE e.sal > d.avg_sal;