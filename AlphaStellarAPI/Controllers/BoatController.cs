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
    public class BoatController : ControllerBase
    {
        private IBoatRepository _boatRepository;

        public BoatController(IBoatRepository boatRepository)
        {
            _boatRepository = boatRepository;
        }

        [HttpGet("byColor")]

        public ActionResult<IEnumerable<Boat>> GetBoatByColor(string color)
        {
            var list = _boatRepository.GetBoatByColor(color);
            return list;
        }
    }
}
