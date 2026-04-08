Create Database StudentCourseApiProject;

Use StudentCourseApiProject;


Create Table Students
(
	StudentId INT IDENTITY(1,1) PRIMARY KEY,
	StudentName varchar(100) not null,
	StudentEmail varchar(100) not null unique
);




Create Table Courses
(
	CourseId int primary key identity(1,1),
	CourseName varchar(100) not null,
	CourseDuration INT NOT NULL
);


CREATE TABLE Enrollments (
    EnrollmentId INT IDENTITY(1,1) PRIMARY KEY,
    StudentId INT NOT NULL,
    CourseId INT NOT NULL,
    CONSTRAINT FK_Enrollments_Students FOREIGN KEY (StudentId) REFERENCES Students(StudentId),
    CONSTRAINT FK_Enrollments_Courses FOREIGN KEY (CourseId) REFERENCES Courses(CourseId)
);

select * from Students;
select * from Courses;
select * from Enrollments;


select @@SERVERNAME;