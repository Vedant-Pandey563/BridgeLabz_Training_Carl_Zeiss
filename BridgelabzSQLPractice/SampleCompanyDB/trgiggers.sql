-- triggers

-- insert trigger

use SampleCompanyDB;

CREATE TABLE emp_audit (
 empno INT,
 ename VARCHAR(10),
 action_type VARCHAR(10),
 action_date DATETIME
);
Select * from emp_audit;

Create trigger trg_emp_after_insert
on emp
after insert
as 
begin
	Insert into emp_audit
	Select empno,ename,'Insert',Getdate()
	From inserted;
end;

INSERT INTO emp VALUES
(7667, 'Test', 'Dude', 7698, GETDATE(), 420, NULL, 30);


select * from emp;


-- update trigger 
create table emp_salary_log(
empno int,
old_sal decimal(10,2),
new_sal decimal(10,2),
changed_on datetime
);


Create trigger trg_emp_sal_update
On emp 
after update
as 
begin 
	if update(sal)
	begin
		insert into emp_salary_log
		Select 
			i.empno,
			d.sal as old_sal,
			i.sal as new_sal,
			Getdate()
			From inserted i
			Join deleted d on i.empno = d.empno;
	End;
End;


update emp
set sal = sal + 47
where ename = 'Test';

select * from emp_salary_log;


--after delete trigger 

Create trigger trg_emp_after_delete
on emp
after delete
as
begin 
	Insert into emp_audit
	Select empno,ename,'Delete',getdate()
	from deleted;
end;

select * from sys.triggers;


