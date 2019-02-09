using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjektMVC.Models.Projekt
{
    public class Drzava
    {
        public int IDDrzava { get; set; }
        [Required(ErrorMessage = "{0} ne može biti prazan.")]
        [DataType(DataType.Text)]
        public string Naziv { get; set; }
    }
}