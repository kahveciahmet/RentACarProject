using Business;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace RentACarWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        /// <summary>
        /// Bu API sayesinde tüm müşterileri getirebilirsiniz.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        /// <summary>
        /// Bu API sayesinde müşterileri id numarasına göre getirebilirsiniz.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _customerService.GetById(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        /// <summary>
        /// Bu API sayesinde müşteri ekleyebilirsiniz.
        /// </summary>
        /// <returns></returns>
        [HttpPost("Add")]
        public IActionResult Add(Customer customer)
        {
            var result = _customerService.Add(customer);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        /// <summary>
        /// Bu API sayesinde müşterileri silebilirsiniz.
        /// </summary>
        /// <returns></returns>
        [HttpPost("Delete")]
        public IActionResult Delete(Customer customer)
        {
            var result = _customerService.Delete(customer);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        /// <summary>
        /// Bu API sayesinde müşterileri güncelleyebilirsiniz.
        /// </summary>
        /// <returns></returns>
        [HttpPost("Update")]
        public IActionResult Update(Customer customer)
        {
            var result = _customerService.Update(customer);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




    }
}
