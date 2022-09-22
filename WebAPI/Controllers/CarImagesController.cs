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
        ICarImagesService _ıcarImageService;
        public CarImagesController(ICarImagesService ıcarImageService)
        {
            _ıcarImageService = ıcarImageService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = "Image")] IFormFile image, [FromForm] CarImages carImage)
        {
            var result = _ıcarImageService.Add(image, carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        // http://localhost:13331/api/carimages/delete
        [HttpPost("delete")]
        public IActionResult Delete(CarImages carImage)
        {
            var result = _ıcarImageService.Delete(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        // http://localhost:13331/api/carimages/getall
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _ıcarImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        // http://localhost:13331/api/carimages/getbyid?id=16
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _ıcarImageService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        // http://localhost:13331/api/carimages/getcarimagesbycarid?carId=3
        [HttpGet("getcarimagesbycarid")]
        public IActionResult GetCarImagesByCarId(int carId)
        {
            var result = _ıcarImageService.GetCarImagesByCarId(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        // http://localhost:13331/api/carimages/update
        [HttpPost("update")]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile formFile, [FromForm] CarImages carImage)
        {
            var result = _ıcarImageService.Update(formFile, carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
