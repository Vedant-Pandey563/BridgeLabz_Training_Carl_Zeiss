--q6

Select ename , empno
from emp e
Join dept d on e.deptno = d.deptno
Where e.ename = 'Clark' and d.dname = 'Accounting';

--q7

Select ename , empno,hiredate
From emp 
Where 
(
	hiredate = (SELECT MAX(hiredate) FROM emp)
);

--q8

Select ename , empno
from emp 
where comm is null;

--q9

Select top 5 ename , sal
from emp
Order By sal desc;

--q10

Select job from emp
Where job LIKE '%MAN%';
