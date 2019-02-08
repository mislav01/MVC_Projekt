using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjektMVC.Models.AW
{
    public class Repository
    {
        private static DataSet ds;
        private static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
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

        internal static IEnumerable<Stavka> GetStavka(int racunID)
        {
            ds = SqlHelper.ExecuteDataset(cs, "GetStavka", racunID);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                yield return new Stavka
                {
                    IDStavka = (int)row["IDStavka"],
                    RacunID = (int)row["RacunID"],
                    Kolicina = (short)row["Kolicina"],
                    ProizvodID = (int)row["ProizvodID"],
                    CijenaPoKomadu = (decimal)row["CijenaPoKomadu"],
                    Popust = (decimal)(row["PopustUPostocima"]) ,
                    UkupnaCijena = (decimal)row["UkupnaCijena"]
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
                    KomercijalistIme = row["Ime"].ToString(),
                    KomercijalistPrezime = row["Prezime"].ToString(),
                    StalniZaposlenik = (bool)row["StalniZaposlenik"],
                    TipKartice = row["Tip"].ToString(),
                    BrojKartice = row["Broj"].ToString(),
                    IstekMjesec = (byte)row["IstekMjesec"],
                    IstekGodina = (short)row["IstekGodina"]
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