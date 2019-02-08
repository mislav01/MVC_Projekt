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
	@GradID INT
AS
BEGIN
	SELECT * FROM Kupac WHERE GradID = @GradID
END

GO

CREATE PROCEDURE GetRacunKomercijalistKartica
	@KupacID INT
AS
BEGIN
	SELECT r.IDRacun, r.DatumIzdavanja, r.BrojRacuna, r.Komentar, k.Ime, k.Prezime, 
	k.StalniZaposlenik, kk.Tip, kk.Broj, kk.IstekMjesec, kk.IstekGodina FROM Racun as r 
	INNER JOIN
	Komercijalist as k 
	ON r.KomercijalistID = k.IDKomercijalist
	INNER JOIN 
	KreditnaKartica as kk 
	ON r.KreditnaKarticaID = kk.IDKreditnaKartica
	WHERE @KupacID = KupacID
END

GO

CREATE PROCEDURE GetStavka
	@RacunID INT
AS
BEGIN
	SELECT * FROM Stavka Where @RacunID = RacunID
END

GO