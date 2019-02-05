USE AdventureWorksOBP
GO

CREATE PROCEDURE GetDrzave
AS
BEGIN
	SELECT * FROM Drzava
END

GO

CREATE PROCEDURE GetGradByDrzavaID
	@DrzavaID INT
AS
BEGIN
	SELECT * FROM Grad WHERE DrzavaID = @DrzavaID
END

GO

CREATE PROCEDURE GetKupacByGradID
	@GradID int
AS
BEGIN
	SELECT * FROM Kupac WHERE GradID = @GradID
END

GO