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
    public class CarController : ControllerBase
    {
        private ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet("byColor")]

        public ActionResult<IEnumerable<Car>> GetCarByColor(string color)
        {
            var list = _carRepository.GetCarByColor(color);
            return list;
        }

        [HttpPost("changeHeadLights/{id}")]

        public ActionResult<Car> ChangeCarHeadLight(int id)
        {
            if (_carRepository.SetCarHeadLights(id))
            {
                return Ok("Işıklar değiştirildi!");
            }
            else
            {
                return BadRequest("Bu id ile bir araba bulunamadı.");
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Car> RemoveCar(int id)
        {
            if (_carRepository.RemoveCar(id))
            {
                return Ok("Araba listeden kaldırıldı!");
            }
            else
            {
                return BadRequest("Bu id ile bir araba bulunamadı.");
            }
        }

    }
}
