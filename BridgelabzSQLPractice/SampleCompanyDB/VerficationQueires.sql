-- verfication queries

-- Count: 4 depts, 14 emps
SELECT 'Depts: ' + CAST(COUNT(*) AS VARCHAR) AS Count FROM dept;
SELECT 'Emps: ' + CAST(COUNT(*) AS VARCHAR) AS Count FROM emp;
-- Sample join
SELECT e.ename, d.dname FROM emp e JOIN dept d ON e.deptno = d.deptno;
