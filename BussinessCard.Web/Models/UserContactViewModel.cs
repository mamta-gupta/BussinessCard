using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BussinessCard.Web.Models
{
    public class UserContactViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string EmailId { get; set; }
        public string MobileNumber { get; set; }
        public string AlternateMobileNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string OrganisationName { get; set; }
        public int OrganisationId { get; set; }
        public string PositionName { get; set; }
        public int PostionId { get; set; }
        public int AddressId { get; set; }
    }
}