using Business;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace RentACarWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        /// <summary>
        /// Bu API sayesinde tüm arabaları getirebilirsiniz.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        /// <summary>
        /// Bu API sayesinde tüm arabaları marka idsine göre getirebilirsiniz.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllByBrandId")]
        public IActionResult GetAllByBrandId(int id)
        {
            var result = _carService.GetAllByBrandId(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        /// <summary>
        /// Bu API sayesinde tüm araba detaylarını getirebilirsiniz.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetCarDetails")]
        public IActionResult GetCarDetails()
        {
            var result = _carService.GetCarDetails();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        /// <summary>
        /// Bu API sayesinde arabaları id numarasına göre getirebilirsiniz.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _carService.GetById(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        /// <summary>
        /// Bu API sayesinde araba ekleyebilirsiniz.
        /// </summary>
        /// <returns></returns>
        [HttpPost("Add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        /// <summary>
        /// Bu API sayesinde araba silebilirsiniz.
        /// </summary>
        /// <returns></returns>
        [HttpPost("Delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        /// <summary>
        /// Bu API sayesinde arabaları güncelleyebilirsiniz.
        /// </summary>
        /// <returns></returns>
        [HttpPost("Update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




    }
}
