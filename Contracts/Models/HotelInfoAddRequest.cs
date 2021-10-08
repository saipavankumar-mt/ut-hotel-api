using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Models
{
    public class HotelInfoAddRequest
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public int StarRating { get; set; }
        public string HotelType { get; set; }
        public string HotelDesc { get; set; }

        public int ReviewRating { get; set; }
        public int ReviewCount { get; set; }

        public string Location { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string HotelAddress { get; set; }

        public string HeroImage { get; set; }
        public List<string> Images { get; set; }

    }
}
