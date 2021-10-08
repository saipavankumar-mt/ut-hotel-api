using Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interface
{
    public interface IHotelIMService
    {
        Task<bool> AddHotelToInventory(HotelInfoAddRequest hotelInfoAddRequest);
        Task<bool> AddRoomCategoryToInventory(HotelRoomCategory hotelRoomCategory);
    }
}
