create database Academy;
go;
use Academy;

CREATE TABLE Groups
(
    GroupID INT PRIMARY KEY IDENTITY(1,1),
    GroupName nvarchar(10) NOT NULL UNIQUE,
    GroupRating INT NOT NULL CHECK(0 < GroupRating AND GroupRating < 5),
    Year INT NOT NULL CHECK(1 < Year AND Year < 5)
);


CREATE TABLE Departments
(
    DepartmentID INT PRIMARY KEY IDENTITY(1,1),
    DepartmentFinancing money NOT NULL CHECK( 0 < DepartmentFinancing) DEFAULT 0,
    DepartmentName nvarchar(100) NOT NULL UNIQUE
);


CREATE TABLE Faculties
(
    FacultyID INT PRIMARY KEY IDENTITY(1,1),
    FacultyName nvarchar(100) NOT NULL UNIQUE
);


CREATE TABLE Teachers
(
    TeacherID INT PRIMARY KEY IDENTITY(1,1),
    EmploymentDate date NOT NULL CHECK('1990-01-01' < EmploymentDate),
    TeacherName nvarchar(max) NOT NULL,
    TeacherSurname nvarchar(max) NOT NULL,
    Premium money NOT NULL CHECK( 0 < Premium) DEFAULT 0,
    Salary money CHECK( 0 <= Salary)
);