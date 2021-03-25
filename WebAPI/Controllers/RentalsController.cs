using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("getallrental")]
        public IActionResult GetAllRental()
        {
            var result = _rentalService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getrentalbyid")]
        public IActionResult GetRentalById(int id)
        {
            var result = _rentalService.GetByID(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getrentalbycarid")]
        public IActionResult GetRentalByCarId(int carId)
        {
            var result = _rentalService.GetByCarID(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getrentalbycustomerid")]
        public IActionResult GetRentalByCustomerId(int customerId)
        {
            var result = _rentalService.GetByCustomerID(customerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getrentalbyrentdate")]
        public IActionResult GetRentalByRentDate(DateTime dateTime)
        {
            var result = _rentalService.GetByRentDate(dateTime);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getrentalbyreturndate")]
        public IActionResult GetRentalByReturnDate(DateTime dateTime)
        {
            var result = _rentalService.GetByReturnDate(dateTime);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addrental")]
        public IActionResult AddRental(Rental rental)
        {
            var result = _rentalService.Add(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleterental")]
        public IActionResult DeleteRental(Rental rental)
        {
            var result = _rentalService.Delete(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updaterental")]
        public IActionResult UpdateRental(Rental rental)
        {
            var result = _rentalService.Update(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
