using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BussinessCard.Web.Models
{
    public class SloganViewModel
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public int OrganisationId { get; set; }

        public virtual OrganisationViewModel Organisation { get; set; }
    }
}