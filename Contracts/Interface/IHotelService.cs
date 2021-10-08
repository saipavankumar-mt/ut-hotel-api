using Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interface
{
    public interface IHotelService
    {
        Task<HotelSearchResponse> SearchHotelsAsync(HotelSearchRequest hotelSearchRequest);
        Task<HotelAvailableRoomsResponse> GetRoomsResponse(string hotelId);
        Task<HotelPriceSummary> HotelPriceSummary(HotelRoomsPriceRequest hotelRoomsPriceRequest);
    }
}
