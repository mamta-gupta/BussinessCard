using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BussinessCard.Web.Models
{
    public class ContactViewModel
    {
        public int Id { get; set; }
        public int OrganisationId { get; set; }
        public int PositionId { get; set; }
        public int LogoId { get; set; }
        public virtual OrganisationViewModel Organisation { get; set; }
        public virtual PositionViewModel Position { get; set; }
    }
}