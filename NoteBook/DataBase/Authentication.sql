CREATE DATABASE NoteBook_Authentication
USE NoteBook_Authentication

CREATE TABLE AuthenticationInformation(
	UserName VARCHAR(50)NOT NULL,
	Email VARCHAR(50),
	PasswordHash VARCHAR(100) NOT NULL,
	PRIMARY KEY(UserName),
	FOREIGN KEY (UserName) REFERENCES UserInformation(UserName),
	FOREIGN KEY (Email) REFERENCES UserInformation(Email)
)

CREATE TABLE UserInformation(
	UserName VARCHAR(50) NOT NULL,
	FirstName VARCHAR(50),
	LastName VARCHAR(50),
	PhoneNumber VARCHAR(50) UNIQUE,
	Email VARCHAR(50) UNIQUE,
	PRIMARY KEY(UserName)
)

