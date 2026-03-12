--create login
Create login testuser
with password = 'Test@123';

--create user in db
Use SampleCompanyDB;
Go

Create user testuser
for login testuser;

-- give permisssions
Alter role db_datareader add member testuser;
Alter role db_datawriter add member testuser;

