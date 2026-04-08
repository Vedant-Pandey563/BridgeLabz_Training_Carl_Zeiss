CREATE DATABASE StudentCourseApiProject;
GO

USE StudentCourseApiProject;
GO

CREATE TABLE Students (
    StudentId INT IDENTITY(1,1) PRIMARY KEY,
    StudentName NVARCHAR(50) NOT NULL,
    StudentEmail NVARCHAR(100) NOT NULL UNIQUE
);
GO

CREATE TABLE Courses (
    CourseId INT IDENTITY(1,1) PRIMARY KEY,
    CourseName NVARCHAR(50) NOT NULL,
    CourseDuration INT NOT NULL
);
GO

CREATE TABLE Enrollments (
    EnrollmentId INT IDENTITY(1,1) PRIMARY KEY,
    StudentId INT NOT NULL,
    CourseId INT NOT NULL,
    CONSTRAINT FK_Enrollments_Students FOREIGN KEY (StudentId) REFERENCES Students(StudentId),
    CONSTRAINT FK_Enrollments_Courses FOREIGN KEY (CourseId) REFERENCES Courses(CourseId),
    CONSTRAINT UQ_Enrollments_Student_Course UNIQUE (StudentId, CourseId)
);
GO
