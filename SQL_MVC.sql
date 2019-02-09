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
	SELECT r.IDRacun, r.DatumIzdavanja, r.BrojRacuna, r.Komentar, k.IDKomercijalist, k.Ime, k.Prezime, 
	k.StalniZaposlenik, kk.IDKreditnaKartica, kk.Tip, kk.Broj, kk.IstekMjesec, kk.IstekGodina FROM Racun as r 
	INNER JOIN
	Komercijalist as k 
	ON r.KomercijalistID = k.IDKomercijalist
	INNER JOIN 
	KreditnaKartica as kk 
	ON r.KreditnaKarticaID = kk.IDKreditnaKartica
	WHERE @KupacID = KupacID
END

GO

CREATE PROCEDURE GetStavkaProizvodPotkategorijaKategorija
	@RacunID INT
AS
BEGIN
	SELECT s.IDStavka, s.Kolicina, s.CijenaPoKomadu, s.PopustUPostocima, s.UkupnaCijena,
	p.IDProizvod, p.Naziv, p.BrojProizvoda, p.Boja, p.MinimalnaKolicinaNaSkladistu, p.CijenaBezPDV, pk.IDPotkategorija,
	pk.Naziv, k.IDKategorija, k.Naziv FROM Stavka as s 
	INNER JOIN
	Proizvod as p 
	ON s.ProizvodID = p.IDProizvod
	INNER JOIN 
	Potkategorija as pk
	ON p.PotkategorijaID = pk.IDPotkategorija
	INNER JOIN
	Kategorija as k
	ON pk.KategorijaID = k.IDKategorija
	WHERE @RacunID = RacunID
END