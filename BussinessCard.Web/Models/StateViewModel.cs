using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BussinessCard.Web.Models
{
    public class StateViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public virtual CountryViewModel Country { get; set; }
    }
}