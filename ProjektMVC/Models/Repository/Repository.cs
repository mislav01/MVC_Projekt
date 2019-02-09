using Microsoft.ApplicationBlocks.Data;
using ProjektMVC.Models.Projekt;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace ProjektMVC.Models.Repository
{
    public class Repository
    {
        private static DataSet ds;
        private static DataRow dr;
        private static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        internal static object EditKupac(Kupac kupac)
        {
            throw new NotImplementedException();
        }

        internal static IEnumerable<Drzava> GetDrzave()
        {
            ds = SqlHelper.ExecuteDataset(cs, "GetDrzave");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                yield return new Drzava
                {
                    IDDrzava = (int)row["IDDrzava"],
                    Naziv = row["Naziv"].ToString()
                };
            }
        }

        internal static IEnumerable<Stavka> GetStavkaProizvodPotkategorijaKategorija(int racunID)
        {
            ds = SqlHelper.ExecuteDataset(cs, "GetStavkaProizvodPotkategorijaKategorija", racunID);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                yield return new Stavka
                {
                    IDStavka = (int)row["IDStavka"],
                    Kolicina = (short)row["Kolicina"],
                    CijenaPoKomadu = (decimal)row["CijenaPoKomadu"],
                    Popust = (decimal)(row["PopustUPostocima"]),
                    UkupnaCijena = (decimal)row["UkupnaCijena"],

                    Proizvod = new Proizvod
                    {
                        IDProizvod = (int)row["IDProizvod"],
                        Naziv = row["Naziv"].ToString(),
                        BrojProizvoda = row["BrojProizvoda"].ToString(),
                        Boja = row["Boja"].ToString(),
                        MinimalnaKolicinaNaSkladistu = (short)row["MinimalnaKolicinaNaSkladistu"],
                        CijenaBezPDV = (decimal)row["CijenaBezPDV"]
                    },

                    Potkategorija = new Potkategorija
                    {
                        IDPotkategorija = (int)row["IDPotkategorija"],
                        Naziv = row["Naziv"].ToString()
                    },

                    Kategorija = new Kategorija
                    {
                        IDKategorija = (int)row["IDKategorija"],
                        Naziv = row["Naziv"].ToString()
                    }
                };
            }
        }

        internal static IEnumerable<Racun> GetRacunKomercijalistKartica(int kupacID)
        {
            ds = SqlHelper.ExecuteDataset(cs, "GetRacunKomercijalistKartica", kupacID);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                yield return new Racun
                {
                    IDRacun = (int)row["IDRacun"],
                    DatumIzdavanja = (DateTime)row["DatumIzdavanja"],
                    BrojRacuna = row["BrojRacuna"].ToString(),
                    Komentar = row["Komentar"].ToString(),

                    Komercijalist = new Komercijalist
                    {
                        IDKomercijalist = (int)row["IDKomercijalist"],
                        KomercijalistIme = row["Ime"].ToString(),
                        KomercijalistPrezime = row["Prezime"].ToString(),
                        StalniZaposlenik = (bool)row["StalniZaposlenik"]
                    },

                    KreditnaKartica = new KreditnaKartica
                    {
                        IDKreditnaKartica = (int)row["IDKreditnaKartica"],
                        TipKartice = row["Tip"].ToString(),
                        BrojKartice = row["Broj"].ToString(),
                        IstekMjesec = (byte)row["IstekMjesec"],
                        IstekGodina = (short)row["IstekGodina"]
                    }
                };
            }
        }

        internal static IEnumerable<Kupac> GetKupacByGradID(int gradID)
        {
            ds = SqlHelper.ExecuteDataset(cs, "GetKupacByGradID", gradID);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                yield return new Kupac
                {
                    IDKupac = (int)row["IDKupac"],
                    Ime = row["Ime"].ToString(),
                    Prezime = row["Prezime"].ToString(),
                    Email = row["Email"].ToString(),
                    Telefon = row["Telefon"].ToString(),
                    GradID = (int)row["GradID"]
                };
            }
        }

        internal static Kupac GetKupacByID(int kupacID)
        {
            dr = SqlHelper.ExecuteDataset(cs, "GetKupacByID", kupacID).Tables[0].Rows[0];

            return new Kupac
            {
                IDKupac = (int)dr["IDKupac"],
                Ime = dr["Ime"].ToString(),
                Prezime = dr["Prezime"].ToString(),
                Email = dr["Email"].ToString(),
                Telefon = dr["Telefon"].ToString(),
                GradID = (int)dr["GradID"]
            };

        }

        internal static IEnumerable<Grad> GetGradByDrzavaID(int drzavaID)
        {
            ds = SqlHelper.ExecuteDataset(cs, "GetGradByDrzavaID", drzavaID);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                yield return new Grad
                {
                    IDGrad = (int)row["IDGrad"],
                    Naziv = row["Naziv"].ToString(),
                    DrzavaID = (int)row["DrzavaID"]
                };
            }
        }
    }
}