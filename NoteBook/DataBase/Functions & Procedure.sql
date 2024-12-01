USE NoteBook_Authentication


-- Username Function check
CREATE FUNCTION UDFcheckIfExists(@Username VARCHAR(50))
Returns INT
AS
BEGIN
	IF EXISTS (SELECT 1 FROM UserInformation WHERE UserName = @Username)
	BEGIN
		RETURN 1
	END
	RETURN 0
END

-- Data procedure transfer
CREATE PROCEDURE UDPsetUserInformation(
	@Username VARCHAR(50),
	@FirstName VARCHAR(50),
	@LastName VARCHAR(50),

)
AS
BEGIN
	
END