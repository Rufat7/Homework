CREATE TABLE Faculties (
		id int primary key IDENTITY(1,1),
		[Name] nvarchar(max) NOT NULL
	);
 
	CREATE TABLE Departments(
		id int primary key IDENTITY(1,1),
		[Name] nvarchar(max) NOT NULL,
		Financing money NOT NULL DEFAULT 0 CHECK(Financing > 0),
		FacultiesId int NOT NULL foreign key references Faculties(id)
	);
	CREATE TABLE [Subject] (
		id int primary key IDENTITY(1,1),
		[Name] nvarchar(max) NOT NULL
	);
	CREATE TABLE Teachers(
		id int primary key IDENTITY(1,1),
		[Name] nvarchar(max) NOT NULL,
		Surname nvarchar(max) NOT NULL,
		Salary money NOT NULL CHECK(Salary > 0)
	);

	CREATE TABLE Groups(
		id int primary key IDENTITY(1,1),
		[Name] nvarchar(max) NOT NULL,
		CourseYear int NOT NULL CHECK(CourseYear > 1 AND CourseYear < 5),
		DepartmentId int foreign key references Departments(id),
	);
	CREATE TABLE Lectures(
		id int primary key IDENTITY(1,1),
		DayOfWeak int  NOT NULL CHECK(DayOfWeak >= 1 AND DayOfWeak <= 7),
		LectureRoom nvarchar(max) NOT NULL,
		SubjectId int foreign key references [Subject](id),
		TeacherId int foreign key references Teachers(id)
	);
	CREATE TABLE GroupsLectures(
		id int primary key IDENTITY(1,1),
		GroupId int foreign key references Groups(id),
		LecturesId int foreign key references Lectures(id)
	);

	SELECT COUNT(*) AS TeachersCount
	FROM Teachers T
	JOIN Departments D ON T.Id = D.Id
	WHERE D.Name = 'Software Development';

	SELECT COUNT(*) AS LecturesCount
	FROM Lectures L
	JOIN Teachers T ON L.TeacherId = T.Id
	WHERE T.Name = 'Dave McQueen';

	SELECT COUNT(*) AS ClassesCount
	FROM Lectures
	WHERE LectureRoom = 'D201';

	SELECT LectureRoom, COUNT(*) AS LecturesCount
	FROM Lectures
	GROUP BY LectureRoom;

	select COUNT(*) as StudentCount
	FROM GroupsLectures GL
	JOIN Lectures L ON GL.Id = L.Id
	JOIN Teachers T ON L.TeacherId = T.Id
	WHERE T.Name = 'Jack' and T.Surname = 'Underhill';

	SELECT AVG(Salary) AS AverageSalary
	FROM Teachers T
	JOIN Departments D ON T.Id = D.Id
	JOIN Faculties F ON D.FacultiesId = F.Id
	WHERE F.Name = 'Computer Science';

	SELECT MIN(StudentsCount) AS MinStudents, MAX(StudentsCount) AS MaxStudents
	FROM (
		SELECT G.Id, G.Name, COUNT(GL.Id) AS StudentsCount
		FROM Groups G
		JOIN GroupsLectures GL ON G.Id = GL.GroupId
		GROUP BY G.Id, G.Name
	) AS GroupStudents;


	SELECT AVG(Financing) AS AverageFinancing
	FROM Departments;

	SELECT CONCAT(Name, ' ', Surname) as FullName, count(*) as SubjectsTaught
	FROM Teachers T
	JOIN Lectures L ON T.Id = L.TeacherId
	GROUP BY T.Id, T.Name, T.Surname;

	SELECT DayOfWeak, COUNT(*) AS LecturesCount
	FROM Lectures
	GROUP BY DayOfWeak;

	SELECT L.LectureRoom, COUNT(DISTINCT D.Id) AS DepartmentsCount
	FROM Lectures L
	JOIN Teachers T ON L.TeacherId = T.Id
	JOIN Departments D ON T.Id = D.Id
	GROUP BY L.LectureRoom;

	SELECT F.Name AS FacultyName, COUNT(DISTINCT L.SubjectId) AS SubjectsCount
	FROM Faculties F
	JOIN Departments D ON F.Id = D.FacultiesId
	JOIN Teachers T ON D.Id = T.Id
	JOIN Lectures L ON T.Id = L.TeacherId
	GROUP BY F.Id, F.Name;