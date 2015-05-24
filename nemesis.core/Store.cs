using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nemesis.Core
{
    public class Store
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public string Postcode { get; set; }

        public string OpeningHours { get; set; }

        public Store()
        { }

        public Store(string id, string name, string address, string postcode, string openingHours)
        {
            Id = id;
            Name = name;
            Address = address;
            Postcode = postcode;
            OpeningHours = openingHours;
        }
    }

}