using Contracts.Interface;
using Contracts.Models;
using System;
using System.Threading.Tasks;

namespace HotelService
{
    public class HotelService : IHotelService
    {
        public HotelService()
        {

        }

        public Task<HotelAvailableRoomsResponse> GetRoomsResponse(string hotelId)
        {
            throw new NotImplementedException();
        }

        public Task<HotelPriceSummary> HotelPriceSummary(HotelRoomsPriceRequest hotelRoomsPriceRequest)
        {
            throw new NotImplementedException();
        }

        public Task<HotelSearchResponse> SearchHotelsAsync(HotelSearchRequest hotelSearchRequest)
        {
            throw new NotImplementedException();
        }
    }
}
