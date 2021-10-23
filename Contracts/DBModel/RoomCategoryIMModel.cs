using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.DBModel
{
    public class RoomCategoryIMModel
    {
        public string rid { get; set; }
        public string rname { get; set; }
        public string rcap { get; set; }
        // , seperated urls
        public string rimgs { get; set; } 
        public string rinfo { get; set; }
        public string ramenities { get; set; }
    }
}
 