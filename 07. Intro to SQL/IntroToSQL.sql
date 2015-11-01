use TelerikAcademy;

SELECT * FROM Departments

SELECT Name FROM Departments

SELECT Salary FROM Employees 
ORDER BY Salary

SELECT FirstName + ' ' + LastName As FullName
FROM Employees

SELECT FirstName + '.' + LastName + '@telerik.com' As 'Full Email Addresses'
FROM Employees

SELECT
DISTINCT Salary
FROM Employees

SELECT *
FROM Employees
WHERE JobTitle = 'Sales Representative'

SELECT FirstName
FROM Employees
WHERE FirstName LIKE 'SA%'

SELECT LastName
FROM Employees
WHERE CHARINDEX('ei', LastName) > 0

SELECT Salary
FROM Employees
WHERE Salary >= 20000 AND Salary <= 30000

SELECT FirstName + ' ' + LastName As FullName, Salary
FROM Employees
WHERE Salary IN (25000, 14000, 12500, 23600)

SELECT FirstName + ' ' + LastName As FullName, ManagerID
FROM Employees
WHERE ManagerID IS NULL

SELECT Salary
FROM Employees
WHERE Salary > 50000
ORDER BY Salary DESC

SELECT TOP 5 Salary
FROM Employees
ORDER BY Salary DESC

SELECT e.FirstName EmpFirstName, a.AddressText EmpAddress
FROM Employees e
INNER JOIN Addresses a
ON e.AddressID = a.AddressID

SELECT e.FirstName EmpFirstName, a.AddressText EmpAddress
FROM Employees e, Addresses a
WHERE e.AddressID = a.AddressID

SELECT e.FirstName EmpFirstName, m.FirstName MngFirstName
FROM Employees e, Employees m
WHERE e.ManagerID = m.EmployeeID

SELECT e.FirstName Employee, m.FirstName Manager, a.AddressText Addresses
FROM Employees e
JOIN Employees m
ON e.ManagerID = m.EmployeeID
JOIN Addresses a
ON e.AddressID = a.AddressID

SELECT Name 
FROM Departments
UNION
SELECT Name
FROM Towns

SELECT e.LastName EmpLastName, m.EmployeeID MgrLastName
FROM Employees e 
RIGHT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID

SELECT e.LastName EmpLastName, m.EmployeeID MgrLastName
FROM Employees e 
LEFT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID

SELECT e.FirstName FirstName, e.LastName LastName
FROM Employees e
INNER JOIN Departments d
ON e.DepartmentID = d.DepartmentID 
AND (d.Name = 'Sales' OR d.Name = 'Finance')
ORDER BY FirstName, LastName