using Contracts.DBModel;
using Contracts.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SQLLiteDBProvider.Providers
{
    public class HotelIMProvider : IHotelIMProvider
    {
        public Task<bool> AddHotelToHotelTable(HotelIMModel hotelIMModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddOrUpdateRoomToHotel(string hotelId, string inventoryDate, HotelRoomIMModel roomIMModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddRoomCategoryToCategoryTable(RoomCategoryIMModel categoryIMModel)
        {
            throw new NotImplementedException();
        }

        public Task<HotelIMModel> GetHotelById(string hotelId)
        {
            throw new NotImplementedException();
        }

        public Task<HotelRoomIMModel> GetRoom(string hotelId, string fetchDate)
        {
            throw new NotImplementedException();
        }
    }
}
