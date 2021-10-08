using Contracts.Interface;
using Contracts.Models;
using System;
using System.Threading.Tasks;

namespace HotelIMService
{
    public class HotelIMService : IHotelIMService
    {
        public HotelIMService()
        {

        }

        public Task<bool> AddHotelToInventory(HotelInfoAddRequest hotelInfoAddRequest)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddRoomCategoryToInventory(HotelRoomCategory hotelRoomCategory)
        {
            throw new NotImplementedException();
        }
    }
}
