-- DEPT table
CREATE TABLE dept (
deptno INT NOT NULL PRIMARY KEY,
dname VARCHAR(14) NOT NULL,
loc VARCHAR(13) NOT NULL
);
-- EMP table (mgr self-references empno)
CREATE TABLE emp (
empno INT NOT NULL PRIMARY KEY,
ename VARCHAR(10) NOT NULL,
job VARCHAR(9) NOT NULL,
mgr INT NULL,
hiredate DATE NOT NULL,
sal DECIMAL(7,2) NOT NULL,
comm DECIMAL(7,2) NULL,
deptno INT NOT NULL,
CONSTRAINT fk_deptno FOREIGN KEY (deptno) REFERENCES dept(deptno),
CONSTRAINT fk_mgr FOREIGN KEY (mgr) REFERENCES emp(empno)
);
-- BONUS (commented as in original)
 CREATE TABLE bonus (
 ename VARCHAR(10),
 job VARCHAR(9),
 sal DECIMAL(7,2),
 comm DECIMAL(7,2)
 );
-- SALGRADE (commented as in original)
 CREATE TABLE salgrade (
 grade INT,
 losal DECIMAL(7,2),
 hisal DECIMAL(7,2)
 );