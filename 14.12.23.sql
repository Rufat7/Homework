CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Age INT,
    GPA FLOAT
);

CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(50),
    Difficulty INT,
    Credits INT
);

CREATE TABLE Enrollments (
    EnrollmentID INT PRIMARY KEY,
    StudentID INT,
    CourseID INT,
    Grade FLOAT
);

INSERT INTO Students (StudentID, FirstName, LastName, Age, GPA)
VALUES
    (1, 'Rufat', 'Aliyev', 16, 5.0),
    (2, 'Ali', 'Ismayil', 15, 4.0),
	(3, 'Javad', 'Rahimli', 19, 3.6),
	(4, 'Ali', 'Shirinov', 17, 3.5),
	(5, 'Atilla', 'Rustam', 16, 4.3),
	(6, 'Ziya', 'Gadzhily', 16, 3.0),
	(7, 'Rustam', 'Niftaliyev', 26, 5.0),
	(8, 'Igor', 'Kostolomov', 24, 3.5),
	(9, 'Khanan', 'Mamedli', 15, 4.5),
	(10, 'Ramil', 'Teymurov', 20, 4.5),
	(11, 'Elnur', 'Mamedov', 20, 4.7),
	(12, 'Agasaf', 'Mammedov', 18, 4.4);
	


INSERT INTO Courses (CourseID, CourseName, Difficulty, Credits)
VALUES
        (101, 'Mathematics', 5, 4),
		(102, 'Literature', 4, 2),
		(103, 'Chemistry', 3, 4),
		(104, 'Russian', 4, 3),
		(105, 'Computer Science', 5, 4),
		(106, 'Mathematics', 5, 4),
		(107, 'History', 2, 2),
		(108, 'English', 4, 4),
		(109, 'Physics', 3, 2),
		(110, 'Biology', 3, 4);


INSERT INTO Enrollments (EnrollmentID, StudentID, CourseID, Grade)
VALUES
    (1, 1, 101, 3.7),
    (2, 1, 102, 4.0),
    (3, 2, 101, 3.9),
    (4, 3, 103, 3.5),
    (5, 3, 105, 3.2),
    (6, 4, 102, 3.8),
    (7, 4, 104, 4.0),
    (8, 5, 105, 3.1),
	(9, 5, 101, 3.0);


	select AVG(Grade) from Enrollments where CourseID = 101;
	select MAX(Age) from Students where GPA > 3.5;
	select COUNT(CourseName) from Courses where Difficulty > 3;
	select AVG(Credits) from Courses;
	select Max(Difficulty) from Courses;