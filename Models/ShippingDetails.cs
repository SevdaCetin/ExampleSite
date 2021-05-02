using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExampleSite.Models
{
    public class ShippingDetails
    {

        public string Username { get; set; }
        [Required(ErrorMessage="Lütfen Adres Giriniz")]
        public string Adres { get; set; }
        [Required(ErrorMessage = "Lütfen Sehir Giriniz")]
        public string Sehir { get; set; }
        [Required(ErrorMessage = "Lütfen Semt Giriniz")]
        public string Semt { get; set; }
        [Required(ErrorMessage = "Lütfen Mahalle Giriniz")]
        public string Mahalle { get; set; }
        [Required(ErrorMessage = "Lütfen Postakodu Giriniz")]
        public string Postakodu { get; set; }
    }
}