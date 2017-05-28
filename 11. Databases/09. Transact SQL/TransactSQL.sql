-- 1.
CREATE DATABASE AccountSystem
GO

use AccountSystem

CREATE TABLE Persons(
	PersonID INT IDENTITY(1,1),
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	SSN NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_Persons PRIMARY KEY(PersonID)
)
GO

CREATE TABLE Accounts(
	AccountID INT IDENTITY(1,1),
	Balance INT NOT NULL,
	CONSTRAINT PK_Accounts PRIMARY KEY(AccountID)
)
GO

ALTER TABLE Accounts 
	ADD PersonID int 
ALTER TABLE Accounts
	ADD CONSTRAINT FK_Accounts_Persons
	  FOREIGN KEY (PersonID)
	  REFERENCES Persons(PersonID)
GO

CREATE PROC dbo.usp_FullNamesOfPersons
AS
	SELECT FirstName + ' ' + LastName AS FullName
	FROM Persons
GO

EXEC usp_FullNamesOfPersons

-- 2.
CREATE PROC dbo.usp_PersonsWithMoreMoneyThanNumber(@minBalance int = 400)
AS
	SELECT p.FirstName + ' ' + p.LastName AS FullName, a.Balance AS Balance
	FROM Persons p
	JOIN Accounts a
	ON p.PersonID = a.PersonID
	WHERE a.Balance > @minBalance
GO

EXEC usp_PersonsWithMoreMoneyThanNumber

-- 3.
CREATE FUNCTION dbo.fn_CalculateInterestAmount
	(
		@sum int,
		@yearlyInterestRate money,
		@monthsCount int
	)
RETURNS MONEY 
AS
	BEGIN
		RETURN (@sum * @yearlyInterestRate * @monthsCount)
	END
GO

DECLARE @ret MONEY
EXEC @ret = dbo.fn_CalculateInterestAmount @sum = 2000, @yearlyInterestRate = 0.7, @monthsCount = 12
PRINT @ret

-- 4.
CREATE PROC dbo.usp_InterestForPersonAccountToOneMonth(@accountID int = 1, @interestRate MONEY = 0.7)
AS
	SELECT dbo.fn_CalculateInterestAmount(Balance, @interestRate, 1) AS Result
	FROM Accounts 
	WHERE AccountID = @accountID
GO

EXEC dbo.usp_InterestForPersonAccountToOneMonth

-- 5.
CREATE PROC dbo.usp_WithDrawMoney(@accountID int, @money MONEY)
AS
	IF @money < (SELECT Balance FROM Accounts WHERE AccountID = @accountID)
		UPDATE Accounts
			SET Balance = Balance - @money
			WHERE AccountID = @accountID
GO

EXEC dbo.usp_WithDrawMoney @accountID = 1, @money = 20.0


CREATE PROC dbo.usp_DepositMoney(@accountID int, @money MONEY)
AS
	UPDATE Accounts
		SET Balance = Balance + @money
		WHERE AccountID = @accountID
GO

EXEC dbo.usp_DepositMoney @accountID = 1, @money = 50.0

-- 6.
CREATE TABLE Logs(
	LogID INT IDENTITY(1,1),
	OldSum INT NOT NULL,
	NewSum INT NOT NULL,
	AccountID INT NOT NULL,
	CONSTRAINT PK_Logs PRIMARY KEY(LogID),
	CONSTRAINT FK_Logs_Accounts
	  FOREIGN KEY (AccountID)
	  REFERENCES Accounts(AccountID)
)
GO

CREATE TRIGGER tr_BalanceUpdate ON Accounts AFTER UPDATE
AS
	INSERT INTO Logs (OldSum, NewSum, AccountID)
	SELECT d.Balance, i.Balance, i.AccountID
      FROM Inserted i
      INNER JOIN Deleted d 
	  ON i.AccountID = d.AccountID
GO

EXEC dbo.usp_DepositMoney @accountID = 1, @money = 50.0



