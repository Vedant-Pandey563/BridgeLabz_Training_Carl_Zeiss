--joins

--inner join
SELECT e.empno,e.ename,e.sal,d.dname,d.loc
FROM emp e
INNER JOIN dept d ON e.deptno = d.deptno
ORDER BY e.ename;


--left join
SELECT e.empno,e.ename,e.sal,d.dname,d.loc
FROM emp e
left JOIN dept d ON e.deptno = d.deptno
ORDER BY e.ename;

--right join
SELECT e.empno,e.ename,e.sal,d.dname,d.loc
FROM emp e
right JOIN dept d ON e.deptno = d.deptno
ORDER BY d.dname;

-- outer join

Select e.empno,e.ename as employee,
d.dname,d.loc as department
From emp e 
Full Outer Join dept d on e.deptno = d.deptno
Order by d.deptno,e.ename;

-- cross join
SELECT e.ename ,d.dname
From emp e
cross join dept d ; 

--self join
Select e.ename as employee, m.ename as manager
From emp e
join emp m on e.mgr = m.empno;

