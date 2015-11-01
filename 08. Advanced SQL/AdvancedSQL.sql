use TelerikAcademy

SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary = 
	(SELECT MIN(Salary) FROM Employees)

SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary <= 
	(SELECT MIN(Salary + (Salary / 10)) FROM Employees)

SELECT e.FirstName + ' ' + e.LastName as FullName, e.Salary, d.Name
FROM Employees e
INNER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE Salary = 
	(SELECT MIN(Salary) FROM Employees)

SELECT AVG(Salary) Avg
FROM Employees
WHERE DepartmentID = 1

SELECT AVG(e.Salary) Avg
FROM Employees e
INNER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

SELECT COUNT(*) as PeopleInSales
FROM Employees e
INNER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

SELECT COUNT(*) as PeopleHaveMngCount
FROM Employees 
WHERE ManagerID IS NOT NULL

SELECT COUNT(*) as PeopleHaveMngCount
FROM Employees 
WHERE ManagerID IS NULL

SELECT d.Name, AVG(e.Salary) Avg
FROM Employees e
INNER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name

SELECT t.Name as Town, d.Name as Department, COUNT(*) as EmpCount
FROM Employees e
INNER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
INNER JOIN Addresses a
ON e.AddressID = a.AddressID
INNER JOIN Towns t
ON t.TownID = a.TownID
GROUP BY d.Name, t.Name

SELECT m.FirstName AS FirstName, m.LastName AS LastName
FROM Employees e
INNER JOIN Employees m
ON e.ManagerID = m.EmployeeID
GROUP BY m.FirstName, m.LastName
HAVING COUNT(e.ManagerID) = 5

-- 12.
SELECT m.FirstName + ' ' + m.LastName AS Manager, 
	e.FirstName + ' ' + e.LastName AS Employee
FROM Employees e
INNER JOIN Employees m
ON e.ManagerID = m.EmployeeID 
UNION
SELECT 'NO MANAGER' AS Manager, 
	e.FirstName + ' ' + e.LastName AS Employee
FROM Employees e
WHERE e.ManagerID IS NULL

-- 13.
SELECT LastName
FROM Employees
GROUP BY LastName
HAVING LEN(LastName) = 5

-- 14.
SELECT CONVERT(VARCHAR(30), GETDATE(), 104)
	+ ' ' + CONVERT(VARCHAR(12), GETDATE(), 114) AS [Time] 

-- 15. The table is created in TelerikAcademy database/tables
CREATE TABLE Users (
	UserID int IDENTITY(1, 1),
	UserName nvarchar(100) NOT NULL,
	UserPassword nvarchar(100) NOT NULL,
	FullName nvarchar(100) NOT NULL,
	LastLogin date NOT NULL,
	CONSTRAINT PK_Users PRIMARY KEY(UserID),
	CONSTRAINT UK_Users UNIQUE(UserName),
	CONSTRAINT chk_User CHECK (LEN(UserPassword) >= 5)
)
GO

-- 16. 
CREATE VIEW [Display Users From Today] AS
SELECT * FROM Users
WHERE LastLogin = 
	(SELECT CONVERT(VARCHAR(10), GETDATE(), 120))
GO

-- 17. The table is created in TelerikAcademy database/tables
CREATE TABLE Groups (
	GroupID int IDENTITY,
	Name nvarchar(100) NOT NULL,
	CONSTRAINT PK_Groups PRIMARY KEY(GroupID),
	CONSTRAINT UK_Groups UNIQUE(Name),
)
GO

-- 18.
ALTER TABLE Users ADD GroupID int 
ALTER TABLE Users
ADD CONSTRAINT FK_Groups_Users
  FOREIGN KEY (GroupID)
  REFERENCES Groups(GroupID)
GO

-- 19.
INSERT INTO Groups 
	(Name)
VALUES 
	('J. Admin'),
	('Adv. User'),
	('J. User')
GO

INSERT INTO Users 
	(UserName, UserPassword, FullName, LastLogin, GroupID)
VALUES 
	('PESHO123', '12345678', 'Peter Nikolov', GETDATE(), 1),
	('PESHO133', '12345678', 'Peter Georgiev', GETDATE(), 2),
	('MARIA_123', '12345678', 'Maria Petrova', GETDATE(), 1)
GO

-- 20.
UPDATE Users
SET FullName = FullName + ' Admin'
WHERE GroupID = 1
GO

UPDATE Groups
SET Name =  'Owner'
WHERE Name = 'Admin'
GO

-- 21.
DELETE FROM Users WHERE UserID = 1
DELETE FROM Groups WHERE GroupID = 4
GO

-- 22.
INSERT INTO Users 
	(UserName, UserPassword, FullName, LastLogin, GroupID)
SELECT SUBSTRING(FirstName, 0, 1) + LOWER(LastName) + CONVERT(nvarchar(30), EmployeeID) AS UserName,
		SUBSTRING(FirstName, 0, 1) + LOWER(LastName) + '12345' AS UserPassword,
		FirstName + ' ' + LastName AS FullName,
		GETDATE() AS LastLogin,
		2 AS GroupID
FROM Employees
GO

-- 23.
UPDATE Users
SET LastLogin = CAST('2010-10-02' as date)
WHERE GroupID = 1
GO

ALTER TABLE Users
ALTER COLUMN UserPassword NVARCHAR(42) NULL

UPDATE Users
SET UserPassword = NULL
WHERE LastLogin < CAST('2010-10-03' as date)
GO

-- 24.
DELETE Users
WHERE UserPassword IS NULL
GO

-- 25.
SELECT d.Name AS Department, e.JobTitle JobTitle, AVG(e.Salary) AS AVGSalary
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle

-- 26.
SELECT d.Name AS Department, e.JobTitle + '-' + e.FirstName AS JobTitle, AVG(e.Salary) AS AVGSalary
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle, e.FirstName

-- 27.
SELECT TOP 1 t.Name AS Town
FROM Employees e
JOIN Addresses a
ON e.AddressID = a.AddressID
JOIN Towns t
ON t.TownID = a.TownID
GROUP BY t.Name
HAVING MAX(e.EmployeeID) > 0
ORDER BY t.Name ASC

--CHECK for how many people is there in Bellevue
--SELECT COUNT(*) AS Cnt
--FROM Employees 
--WHERE AddressID BETWEEN 1 AND 36

-- 28.
SELECT t.Name AS Town, COUNT(DISTINCT e.ManagerID) AS MngCOUNT
FROM Employees e
JOIN Addresses a
ON e.AddressID = a.AddressID
JOIN Towns t
ON t.TownID = a.TownID
GROUP BY t.Name
ORDER BY MngCOUNT DESC

-- 29.
CREATE TABLE WorkHours (
	WorkHourID int IDENTITY(1, 1),
	Task nvarchar(100) NOT NULL,
	HoursPerWeek int NOT NULL,
	Comments nvarchar(100) NOT NULL,
	CreatedOn date NOT NULL,
	EmployeeID int NOT NULL,
	CONSTRAINT PK_WorkHours PRIMARY KEY(WorkHourID),
	CONSTRAINT FK_Employees_WorkHours
	  FOREIGN KEY (EmployeeID)
	  REFERENCES Employees(EmployeeID)
)
GO

INSERT INTO WorkHours 
	(Task, HoursPerWeek, Comments, CreatedOn, EmployeeID)
VALUES
	('Find all Prime number between 1 and 100', 40, 'The problem solved', GETDATE(), 1),
	('Find all Prime number between 1 and 100', 40, 'The problem solved', GETDATE(), 2),
	('Find all Prime number between 1 and 100', 40, 'The problem solved', GETDATE(), 4)
GO

UPDATE WorkHours
SET HoursPerWeek = 50
WHERE EmployeeID = 1
GO

DELETE WorkHours
WHERE HoursPerWeek = 40
GO

-- 30.
BEGIN TRAN
	DELETE FROM Employees
	SELECT d.Name
	FROM Employees e
		JOIN Departments d
			ON e.DepartmentID = d.DepartmentID
	WHERE d.Name = 'Sales'
	GROUP BY d.Name
ROLLBACK TRAN

-- 31.
BEGIN TRAN
DROP TABLE EmployeesProjects
ROLLBACK TRAN

-- 32.
SELECT * 
INTO #Temp FROM EmployeesProjects
DROP TABLE EmployeesProjects
SELECT * INTO EmployeeProjects FROM #Temp
DROP TABLE #Temp