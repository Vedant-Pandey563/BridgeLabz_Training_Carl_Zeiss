Create database StudentDB;

use StudentDB;

CREATE TABLE Students (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Age INT
);

select * from Students;

select @@ServerName;