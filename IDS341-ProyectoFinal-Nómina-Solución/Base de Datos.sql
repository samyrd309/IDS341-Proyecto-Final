create database IDS341
Use IDS341;
Go
--Register table, to access the program. 
CREATE  TABLE Register (
	EmployeeSequence int identity (1,1) PRIMARY KEY,
	FirstName varchar(20) NOT NULL,
	LastName varchar(20) NOT NULL,
	DNI char(11) NOT NULL,
	UserPassword varchar(16) NOT NULL,
	Email varchar(320) NOT NULL,
	UserRole varchar(30) NOT NULL,
	UserName varchar(30) NOT NULL
)
--Payroll table. 
CREATE TABLE Payroll (
	EmployeeSequence int identity (1,1),
	DNI varchar(11) NOT NULL,
	FirstName varchar(20) NOT NULL,
	LastName varchar(20) NOT NULL,
	Position varchar(30) NOT NULL,
	PhoneNumber char(10) NOT NULL, 
	Salary float NOT NULL,
	SocialSecurity float NOT NULL,
	Taxes float NOT NULL,
	Payment float NOT NULL,
	Assistance int NOT NULL,
)

Go
CREATE PROCEDURE spShowPayroll
AS
BEGIN
select DNI, FirstName as 'First name', LastName as 'Last name', Position, PhoneNumber as 'Phone number',Salary, SocialSecurity as 'Social security',Taxes,Payment,Assistance from Payroll
END;


Go
CREATE PROCEDURE spInsertEmployee -- Alters Payroll Table
@DNI char(11),
@FirstName varchar(20),
@LastName varchar(20),
@Position varchar(30),
@PhoneNumber char(10), 
@Salary float,
@SocialSecurity float,
@Taxes float,
@Payment float,
@Assistance int
AS
BEGIN
INSERT INTO Payroll (DNI, FirstName, LastName, Position, PhoneNumber, Salary, SocialSecurity, Taxes, Payment, Assistance) values (@DNI, @FirstName, @LastName, @Position, @PhoneNumber, @Salary, @SocialSecurity, @Taxes, @Payment, @Assistance);
END;

Go
CREATE PROCEDURE spUpdateInfo -- Alters Payroll Table
@DNI char(11),
@FirstName varchar(20),
@LastName varchar(20),
@Position varchar(30),
@PhoneNumber char(10), 
@Salary float,
@SocialSecurity float,
@Taxes float,
@Payment float,
@Assistance int
AS
BEGIN
UPDATE Payroll set FirstName = @FirstName, LastName = @LastName, Position = @Position, PhoneNumber = @PhoneNumber, Salary = @Salary, SocialSecurity = @SocialSecurity, Taxes = @Taxes, Payment = @Payment, Assistance = @Assistance WHERE DNI = @DNI
END;

Go
CREATE PROCEDURE spDeleteEmployee --Alters Register Table
@DNI varchar(11)
AS
BEGIN
DELETE FROM Payroll WHERE DNI = @DNI
END;