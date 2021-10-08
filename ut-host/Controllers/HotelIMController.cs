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
    public class HotelIMController : BaseAPIController
    {
        private IHotelIMService _hotelIMService;
        public HotelIMController(IHotelIMService hotelIMService)
        {
            _hotelIMService = hotelIMService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddHotelToInventory([FromBody] HotelInfoAddRequest hotelInfoAddRequest)
        {
            return Ok(await _hotelIMService.AddHotelToInventory(hotelInfoAddRequest));
        }

        [HttpPost("room/category/add")]
        public async Task<IActionResult> AddRoomCategoryToInventory([FromBody] HotelRoomCategory hotelRoomCategory)
        {
            return Ok(await _hotelIMService.AddRoomCategoryToInventory(hotelRoomCategory));
        }
    }
}
