CREATE TABLE Groups
(
    GroupID INT PRIMARY KEY IDENTITY(1,1),
    GroupName nvarchar(10) NOT NULL UNIQUE,
    GroupRating INT NOT NULL CHECK(0 < GroupRating AND GroupRating < 5),
    GroupYear INT NOT NULL CHECK(1 < GroupYear AND GroupYear < 5)
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
    FacultyName nvarchar(100) NOT NULL UNIQUE,
	Dean nvarchar(max) NOT NULL
);


CREATE TABLE Teachers
(
    TeacherID INT PRIMARY KEY IDENTITY(1,1),
    EmploymentDate date NOT NULL CHECK('1990-01-01' < EmploymentDate),
    TeacherName nvarchar(max) NOT NULL,
    TeacherSurname nvarchar(max) NOT NULL,
    Premium money NOT NULL CHECK( 0 < Premium) DEFAULT 0,
    Salary money CHECK( 0 <= Salary),
	IsAssistant bit NOT NULL DEFAULT 0,
    IsProfessor bit NOT NULL DEFAULT 0,
    Position nvarchar(max) NOT NULL
);

--1.
	SELECT DepartmentName, DepartmentFinancing,DepartmentId FROM Departments;

--2.
	SELECT GroupRating AS "Group Rating",GroupName AS "Group Name" FROM Groups;
--4.
	SELECT CONCAT('The dean of faculty ', FacultyName, ' is ', Dean, '.') AS "Faculty Details"
	FROM Faculties;
--5.
	SELECT TeacherSurname
	FROM Teachers
	WHERE Salary > 1050 AND IsProfessor = 1;
--6.
	SELECT DepartmentName
	FROM Departments
	WHERE DepartmentFinancing < 11000 OR DepartmentFinancing > 25000;
--7.
	SELECT FacultyName
	FROM Faculties
	WHERE FacultyName != 'Computer Science';
--8.
	SELECT Position , TeacherName
	FROM Teachers
	WHERE IsProfessor = 0;
--9.
	SELECT  Premium , Position , TeacherSurname,  Salary 
	FROM Teachers
	WHERE IsAssistant = 1 AND Premium BETWEEN 160 AND 550;
--10.
	SELECT Salary, TeacherSurname
	FROM Teachers
	WHERE IsAssistant = 1;
--11.
	SELECT Position , TeacherSurname
	FROM Teachers
	WHERE EmploymentDate < '2000-01-01';
--12.
	SELECT DepartmentName AS "Name of Department"
	FROM Departments
	WHERE DepartmentName < 'Software Development'
	ORDER BY DepartmentName;
--13.
	SELECT TeacherSurname
	FROM Teachers
	WHERE IsAssistant = 1 AND Premium + Teachers.Salary <= 1200;
--14.
	SELECT GroupName
	FROM Groups
	WHERE GroupYear = 5 AND GroupRating BETWEEN 2 AND 4;
--15.
	SELECT TeacherSurname
	FROM Teachers
	WHERE Premium < 200 OR Salary < 550