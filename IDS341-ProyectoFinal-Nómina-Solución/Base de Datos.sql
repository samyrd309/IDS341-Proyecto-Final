create database IDS341
Use IDS341;
Go

CREATE TABLE Register (
	EmployeeSequence int identity (1,1),
	FirstName varchar(20) NOT NULL,
	LastName varchar(20) NOT NULL,
	DNI char(11) NOT NULL,
	UserPassword varchar(16) NOT NULL,
	Email varchar(320) NOT NULL,
	UserRole varchar(30) NOT NULL
)
drop table Register
select * from Register
insert into Register (FirstName, LastName, DNI, UserPassword, Email, UserRole, UserName) values ('Chris', 'Aquino', '00000000000', 'admin', 'christianaquinomoreta2@gmail.com', 'Admin', 'admin')

CREATE TABLE Payroll (
	ID uniqueidentifier PRIMARY KEY,
	EmployeeSequence int identity (1,1),
	DNI char(11) NOT NULL,
	FirstName varchar(20) NOT NULL,
	LastName varchar(20) NOT NULL,
	Position varchar(30) NOT NULL,
	PhoneNumber char(10) NOT NULL, 
	Salary float NOT NULL,
	SocialSecurity float NOT NULL,
	Taxes float NOT NULL,
	Payment float NOT NULL,
	Assistance int
)

Go
CREATE PROCEDURE spInsertEmployee
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
CREATE PROCEDURE spUpdateInfo
@DNI char(11),
@FirstName varchar(20),
@LastName varchar(20),
@Position varchar(30),
@PhoneNumber char(10), 
@Salary float,
@SocialSecurity float,
@Taxes float,
@Payment float,
@Assistance int,
@EmployeeSequence int
AS
BEGIN
UPDATE Payroll set DNI = @DNI, FirstName = @FirstName, LastName = @LastName, Position = @Position, PhoneNumber = @PhoneNumber, Salary = @Salary, SocialSecurity = @SocialSecurity, Taxes = @Taxes, Payment = @Payment, Assistance = @Assistance WHERE EmployeeSequence = @EmployeeSequence
END;

Go
CREATE PROCEDURE spDeleteEmployee
@DNI char(11)
AS
BEGIN
DELETE FROM Payroll WHERE DNI = @DNI
END;

Go
USE IDS341

Go

ALTER TABLE Register
ADD UserName varchar(16) NOT NULL;
go

CREATE PROCEDURE spCreateUser
@FirstName varchar(20),
@LastName varchar(20),
@DNI char(11),
@UserPassword varchar(16),
@Email varchar(320),
@UserRole varchar(30),
@UserName varchar(16)
AS
BEGIN
INSERT INTO Register (FirstName, LastName, DNI, UserPassword, Email, UserRole, UserName) VALUES (@FirstName, @LastName, @DNI, @UserPassword, @Email, @UserRole, @UserName)
END;


Go
CREATE PROCEDURE spDeleteUser
@UserName varchar(16)
AS
BEGIN
DELETE FROM Register WHERE UserName = @UserName
END;

PRINT "PRUEBA";