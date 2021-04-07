using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpGet("getallcarimage")]
        public IActionResult GetAllCarImage()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcarimagebyid")]
        public IActionResult GetCarImageById(int id)
        {
            var result = _carImageService.GetById(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getcarimagebycarid")]
        public IActionResult GetCarImageByCarId(int id)
        {
            var result = _carImageService.GetByCarId(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost("addcarimage")]
        public IActionResult AddCarImage([FromForm] IFormFile file, [FromForm] CarImage carImage)
        {
            var result = _carImageService.Add(CarImageManager.CarImageNamefixer(file, carImage));
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost("deletecarimage")]
        public IActionResult DeleteCarImage(CarImage carImage)
        {
            var result = _carImageService.Delete(carImage);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost("updatecarimage")]
        public IActionResult UpdateCarImage([FromForm(Name = ("file"))] IFormFile file, [FromForm] CarImage carImage)
        {
            var result = _carImageService.Add(CarImageManager.CarImageNamefixer(file, carImage));
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}
