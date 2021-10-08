using Contracts.Interface;
using Contracts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ut_host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : BaseAPIController
    {
        private IHotelService _hotelService;
        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        
        [HttpPost("search")]
        public async Task<IActionResult> SearchHotelsAsync([FromBody] HotelSearchRequest hotelSearchRequest)
        {
            return Ok(await _hotelService.SearchHotelsAsync(hotelSearchRequest));
        }

        [HttpGet("availablerooms/{hotelId}")]
        public async Task<IActionResult> GetAvailableRooms(string hotelId)
        {
            return Ok(await _hotelService.GetRoomsResponse(hotelId));
        }

        [HttpPost("price")]
        public async Task<IActionResult> HotelPriceSummary([FromBody] HotelRoomsPriceRequest hotelRoomsPriceRequest)
        {
            return Ok(await _hotelService.HotelPriceSummary(hotelRoomsPriceRequest));
        }
    }
}
