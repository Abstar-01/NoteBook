CREATE DATABASE NoteBook_Authentication
USE NoteBook_Authentication

CREATE TABLE AuthenticationInformation(
	UserName VARCHAR(50) NOT NULL,
	PasswordHash VARCHAR(100) NOT NULL
	PRIMARY KEY(UserName)
)

CREATE TABLE UserInformation(
	FirstName VARCHAR(50),
	LastName VARCHAR(50),
	UserName VARCHAR(50),
)