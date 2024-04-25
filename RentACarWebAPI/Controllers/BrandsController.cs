using Business;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace RentACarWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        /// <summary>
        /// Bu API sayesinde tüm markaları getirebilirsiniz.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _brandService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        /// <summary>
        /// Bu API sayesinde markaları id numarasına göre getirebilirsiniz.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _brandService.GetById(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        /// <summary>
        /// Bu API sayesinde marka ekleyebilirsiniz.
        /// </summary>
        /// <returns></returns>
        [HttpPost("Add")]
        public IActionResult Add(Brand brand)
        {
            var result = _brandService.Add(brand);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        /// <summary>
        /// Bu API sayesinde marka silebilirsiniz.
        /// </summary>
        /// <returns></returns>
        [HttpPost("Delete")]
        public IActionResult Delete(Brand brand)
        {
            var result = _brandService.Delete(brand);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        /// <summary>
        /// Bu API sayesinde marka güncelleyebilirsiniz.
        /// </summary>
        /// <returns></returns>
        [HttpPost("Update")]
        public IActionResult Update(Brand brand)
        {
            var result = _brandService.Update(brand);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




    }
}
