using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BussinessCard.Web.Models
{
    public class OrganisationViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int SloganId { get; set; }
        public int AddressId { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public virtual AddressViewModel Address { get; set; }
    }
}