using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCNaprejKoda.Models
{
    public class Filmi
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public DateTime LetoIzdaje { get; set; }
        public string Tip { get; set; }
        public decimal Cena { get; set; }
    }
}