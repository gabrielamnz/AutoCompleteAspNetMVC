using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoCompleteAspNetMVC.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public int CodigoIBGE { get; set; }
        public string UF { get; set; }
        public bool IsCapital { get; set; }
        public string Nome { get; set; }
    }
}