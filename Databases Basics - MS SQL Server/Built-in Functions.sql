--1
SELECT FirstName, LastName FROM Employees
WHERE LEFT(FirstName, 2) = 'SA'

--2
SELECT FirstName, LastName FROM Employees
WHERE LastName LIKE '%ei%'
