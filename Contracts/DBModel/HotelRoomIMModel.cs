using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.DBModel
{
    public class HotelRoomIMModel
    {
        // date + hotelid => 24012021036
        public string iid { get; set; }
        //hotel rooms list. Example: 01|10|2000:02|05|2500   CategoryId:QTY:Price|CategoryId:QTY:Price
        public string hrlist { get; set; }
    }
}
