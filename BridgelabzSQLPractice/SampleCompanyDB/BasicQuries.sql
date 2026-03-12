--q1

Select ename,job from emp;

--q2

Select ename 
From emp
Where ename like 'S%';

--q3

Select ename , hiredate
from emp 
Where Year (hiredate) = '1981';

--q4

Select Distinct job
from emp;

--q5 

Select empno,ename,sal
from emp
Where sal between 1000 and 2000;
