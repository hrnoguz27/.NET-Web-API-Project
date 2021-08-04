using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlphaStellar.Data.Interfaces;
using AlphaStellar.Data.Models;

namespace AlphaStellarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private IBusRepository _busRepository;

        public BusController(IBusRepository busRepository)
        {
            _busRepository = busRepository;
        }

        [HttpGet("byColor")]

        public ActionResult<IEnumerable<Bus>> GetBusByColor(string color)
        {
            var list = _busRepository.GetBusByColor(color);
            return list;
        }
    }
}
