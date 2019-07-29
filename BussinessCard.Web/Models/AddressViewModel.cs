using BussinessCard.Web.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BussinessCard.Web.Models
{
    public class AddressViewModel
    {
        public int Id { get; set; }

        public AddressType AddressType { get; set; }

        public string Street { get; set; }

        public string Street2 { get; set; }

        public int StateId { get; set; }

        public string PinCode { get; set; }

        public virtual StateViewModel State { get; set; }

    }
}