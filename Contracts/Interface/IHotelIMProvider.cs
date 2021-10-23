using Contracts.DBModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interface
{
    public interface IHotelIMProvider
    {
        Task<bool> AddHotelToHotelTable(HotelIMModel hotelIMModel);

        Task<bool> AddRoomCategoryToCategoryTable(RoomCategoryIMModel categoryIMModel);

        Task<bool> AddOrUpdateRoomToHotel(string hotelId, string inventoryDate, HotelRoomIMModel roomIMModel);

        Task<HotelIMModel> GetHotelById(string hotelId);

        Task<HotelRoomIMModel> GetRoom(string hotelId, string fetchDate);
    }
}
