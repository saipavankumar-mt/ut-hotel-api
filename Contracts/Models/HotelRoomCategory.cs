using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Models
{
    public class HotelRoomCategory
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<string> Facilities { get; set; }
        public List<string> CategoryOptions { get; set; }
        public int MaxCapacity { get; set; }
        public List<string> Images { get; set; }
    }
}
