CREATE DATABASE NoteBook_Authentication
USE NoteBook_Authentication

CREATE TABLE AuthenticationInformation(
	UserName VARCHAR(50)NOT NULL,
	Email VARCHAR(50),
	PasswordHash VARCHAR(100) NOT NULL,
	PRIMARY KEY(UserName),
	FOREIGN KEY (UserName) REFERENCES UserInformation(UserName),
	FOREIGN KEY (Email) REFERENCES UserEmail(Email)
)

CREATE TABLE UserInformation(
	UserName VARCHAR(50) NOT NULL,
	FirstName VARCHAR(50),
	LastName VARCHAR(50),
	PRIMARY KEY(UserName)
)

SELECT *FROM UserInformation
INSERT INTO UserInformation(UserName,FirstName,LastName) VALUES
('Abstar','Abel','Girma')
SELECT dbo.UDFcheckIfExists('Abstar')

CREATE TABLE UserPhoneNumber(
	UserName VARCHAR(50),
	PhoneNumber VARCHAR(50),
	PRIMARY KEY(PhoneNumber),
	FOREIGN KEY (UserName) REFERENCES UserInformation(UserName)
)

CREATE TABLE UserEmail(
	UserName VARCHAR(50),
	Email VARCHAR(50),
	PRIMARY KEY(Email),
	FOREIGN KEY (UserName) REFERENCES UserInformation(UserName)
)
