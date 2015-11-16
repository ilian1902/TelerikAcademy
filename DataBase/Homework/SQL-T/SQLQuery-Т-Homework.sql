--1. Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id(PK), PersonId(FK), Balance).
--    Insert few records for testing.
--    Write a stored procedure that selects the full names of all persons.
CREATE DATABASE BankSystem
Go
CREATE TABLE [BankSystem].[dbo].[People] (
PersonID INT IDENTITY,
FirstName NVARCHAR(50),
LastName NVARCHAR(50),
SSN NVARCHAR(50),
CONSTRAINT PK_PersonID PRIMARY KEY (PersonID)
)

CREATE TABLE [BankSystem].[dbo].[Accounts] (
AccountID INT IDENTITY,
PersonID INT NOT NULL,
Balance MONEY NOT NULL,
CONSTRAINT PK_AccountID PRIMARY KEY (AccountID),
CONSTRAINT FK_Accounts_People_PersonID FOREIGN KEY (PersonID) REFERENCES [BankSystem].[dbo].[People](PersonID)
)

INSERT INTO [BankSystem].[dbo].[People] 
	(FirstName,LastName,SSN)
VALUES 
	('Johny','Bravo','43434343'	),
	('Johny','Walker','54545454'),
	('Jim','Beam','65656565'),
	('J','B','87878787')

INSERT INTO [BankSystem].[dbo].[Accounts] 
	(PersonID,Balance)
VALUES 
	(1,1500000.28),
	(2,2245343.04),
	(3,43234.00),
	(4,27123.50)
GO

--2.Create a stored procedure that accepts a number as a parameter and returns all persons who have more money in their accounts than the supplied number.
USE BankSystem
GO
CREATE PROC usp_UsersWithMoreMoney @minMoney MONEY = 0
AS
SELECT p.FirstName,p.LastName,a.Balance FROM [BankSystem].[dbo].[People] p
JOIN [BankSystem].[dbo].[Accounts] a ON p.PersonID=a.PersonID
WHERE a.Balance>@minMoney
GO
	--Test the procedure
EXEC usp_UsersWithMoreMoney @minMoney = 30000
GO

--3.Create a function that accepts as parameters – sum, yearly interest rate and number of months.
--    It should calculate and return the new sum.
--    Write a SELECT to test whether the function works as expected.
USE BankSystem
GO
CREATE FUNCTION ufn_CalculateSumWithInterest (@sum MONEY, @yearInterest DECIMAL, @months INT) RETURNS MONEY
AS
BEGIN
RETURN (@sum + @sum*(@yearInterest/100)*@months/12)
END
GO
DECLARE @sum MONEY = (SELECT Balance FROM Accounts WHERE AccountID = 1)
PRINT dbo.ufn_CalculateSumWithInterest(@sum,5,5)
GO

--4.Create a stored procedure that uses the function from the previous example to give an interest to a person's account for one month.
--    It should take the AccountId and the interest rate as parameters.
USE BankSystem
GO
CREATE PROC usp_AddInterestForOneMonth (@accountID INT,@interest DECIMAL)
AS
DECLARE @sum MONEY = (SELECT Balance FROM Accounts WHERE AccountID = @accountID)
UPDATE Accounts
SET Balance = (@sum+@sum*(@interest/100)/12)
WHERE AccountID = @accountID
GO

EXEC usp_AddInterestForOneMonth 4, 5
GO

--5.Add two more stored procedures WithdrawMoney(AccountId, money) and DepositMoney(AccountId, money) that operate in transactions.
USE BankSystem
GO
CREATE PROC usp_WithdrawMoney (@accountID INT,@money MONEY)
AS
DECLARE @currentBalanace MONEY = (SELECT Balance FROM Accounts WHERE AccountID = @accountID)
IF(@money<=@currentBalanace)
BEGIN
UPDATE Accounts
SET Balance = Balance-@money
WHERE AccountID = @accountID
END
ELSE
BEGIN
PRINT 'Not enough money in account'
END 
GO

--6.Create another table – Logs(LogID, AccountID, OldSum, NewSum).
--         Add a trigger to the Accounts table that enters a new entry into the Logs table every time the sum on an account changes.
USE BankSystem
GO
CREATE TABLE Logs(
LogID INT IDENTITY,
AccountID INT,
OldSum MONEY,
NewSum MONEY,
CONSTRAINT PK_LogID PRIMARY KEY (LogID))
GO

CREATE TRIGGER Tr_AccountUpdate
ON Accounts
FOR UPDATE
AS
SET NOCOUNT ON
INSERT INTO Logs
SELECT
i.AccountID,
d.Balance,
i.Balance
FROM INSERTED i, DELETED d
GO

--7.Define a function in the database TelerikAcademy that returns all Employee's names (first or middle or last name) and all town's names that are comprised of given set of letters.
--         Example: 'oistmiahf' will return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.
USE TelerikAcademy
GO
CREATE FUNCTION ufn_CheckName (@nameToCheck NVARCHAR(50),@letters NVARCHAR(50)) RETURNS INT
AS
BEGIN
        DECLARE @i INT = 1
		DECLARE @currentChar NVARCHAR(1)
        WHILE (@i <= LEN(@nameToCheck))
			BEGIN
				SET @currentChar = SUBSTRING(@nameToCheck,@i,1)
					IF (CHARINDEX(LOWER(@currentChar),LOWER(@letters)) <= 0) 
						BEGIN  
							RETURN 0
						END
				SET @i = @i + 1
			END
        RETURN 1
END
GO

--WITH WHERE AS TABLE
SELECT e.FirstName, e.LastName,t.Name FROM Employees e
JOIN Addresses a ON e.AddressID = a.AddressID
JOIN Towns t ON a.TownID=t.TownID
WHERE 
dbo.ufn_CheckName(e.FirstName,'oistmiahf') = 1 OR 
dbo.ufn_CheckName(e.LastName,'oistmiahf') = 1 OR
dbo.ufn_CheckName(t.Name,'oistmiahf') = 1

--WITH CURSOR AS PRINT
DECLARE employeeTownCursor CURSOR READ_ONLY FOR
  (SELECT e.FirstName, e.LastName, t.Name FROM Employees e
  JOIN Addresses a ON e.AddressID = a.AddressID
	JOIN Towns t ON a.TownID=t.TownID)

OPEN employeeTownCursor
DECLARE @firstName NVARCHAR(50), @lastName NVARCHAR(50), @town NVARCHAR(50)
DECLARE @searchString NVARCHAR(50) ='oistmiahf'
FETCH NEXT FROM employeeTownCursor INTO @firstName, @lastName, @town

WHILE @@FETCH_STATUS = 0
  BEGIN
    IF(dbo.ufn_CheckName(@firstName,@searchString)=1)
		BEGIN
			PRINT 'First name: ' + @firstName
		END
	IF(dbo.ufn_CheckName(@lastName,@searchString)=1)
		BEGIN
			PRINT 'Last name: ' + @lastName
		END
	IF(dbo.ufn_CheckName(@town,@searchString)=1)
		BEGIN
			PRINT 'Town: ' + @town
		END
	FETCH NEXT FROM employeeTownCursor INTO @firstName, @lastName, @town
  END

CLOSE employeeTownCursor
DEALLOCATE employeeTownCursor

--8.Using database cursor write a T-SQL script that scans all employees and their addresses and prints all pairs of employees that live in the same town.
DECLARE employeeTownCursor CURSOR READ_ONLY FOR
  (SELECT e.FirstName, e.LastName, t.Name FROM Employees e
	JOIN Addresses a ON e.AddressID = a.AddressID
	JOIN Towns t ON a.TownID=t.TownID)

OPEN employeeTownCursor
DECLARE @firstName NVARCHAR(50), @lastName NVARCHAR(50), @town NVARCHAR(50)

FETCH NEXT FROM employeeTownCursor INTO @firstName, @lastName,@town

WHILE @@FETCH_STATUS = 0
BEGIN
	DECLARE employeeTownCursor1 CURSOR READ_ONLY FOR
		(SELECT e.FirstName, e.LastName, t.Name FROM Employees e
		JOIN Addresses a ON e.AddressID = a.AddressID
		JOIN Towns t ON a.TownID=t.TownID)
	OPEN employeeTownCursor1
		DECLARE @firstName1 NVARCHAR(50), @lastName1 NVARCHAR(50), @town1 NVARCHAR(50)
		FETCH NEXT FROM employeeTownCursor1 INTO @firstName1, @lastName1,@town1
			WHILE @@FETCH_STATUS = 0
			BEGIN
		
				IF(@town = @town1)
				BEGIN
					PRINT @lastname1 + ': ' + @firstname + ' ' +  @lastname + ' ' + @town + ' ' + @firstname1 
				END

			FETCH NEXT FROM employeeTownCursor1 INTO @firstName1, @lastName1,@town1
			END

	CLOSE employeeTownCursor1
	DEALLOCATE employeeTownCursor1

FETCH NEXT FROM employeeTownCursor INTO @firstName, @lastName,@town
END

CLOSE employeeTownCursor
DEALLOCATE employeeTownCursor

--9.*Write a T-SQL script that shows for each town a list of all employees that live in it.
--         Sample output:
-- 					Sofia -> Martin Kulov, George Denchev
-- 					Ottawa -> Jose Saraiva
--					…
use TelerikAcademy
DECLARE townEmployeesCursor CURSOR READ_ONLY FOR
(SELECT t.Name, dbo.StrConcat(FirstName + ' ' + LastName) AS [List of employees] FROM Employees e
JOIN Addresses a ON a.AddressID = e.AddressID
JOIN Towns t ON t.TownID = a.TownID
GROUP BY t.Name)

OPEN townEmployeesCursor
DECLARE @town NVARCHAR(50), @list NVARCHAR(MAX)

FETCH NEXT FROM townEmployeesCursor INTO @town, @list

WHILE @@FETCH_STATUS = 0
  BEGIN
    PRINT @town + ' -> '+@list
	FETCH NEXT FROM townEmployeesCursor INTO @town, @list
  END

CLOSE townEmployeesCursor
DEALLOCATE townEmployeesCursor

--10.Define a .NET aggregate function StrConcat that takes as input a sequence of strings and return a single string that consists of the input strings separated by ','.
--         For example the following SQL statement should return a single string: 
-- 					SELECT StrConcat(FirstName + ' ' + LastName)
-- 					FROM Employees
USE TelerikAcademy
GO
EXEC sp_configure 'clr enabled', 1
GO
RECONFIGURE
GO

USE TelerikAcademy
CREATE ASSEMBLY ConcatenateStringsWithComma
AUTHORIZATION dbo
--- Please be sure that the dll file is here
FROM 'E:\String\StringConcat\bin\Debug\StringConcat.dll'  
WITH PERMISSION_SET = SAFE
GO

CREATE AGGREGATE dbo.StrConcat (@value nvarchar(MAX)) RETURNS nvarchar(MAX)
EXTERNAL NAME ConcatenateStringsWithComma.[Aggregate.StringConcat] --See below for the names

USE TelerikAcademy
SELECT dbo.StrConcat(FirstName + ' ' + LastName)
FROM Employees

