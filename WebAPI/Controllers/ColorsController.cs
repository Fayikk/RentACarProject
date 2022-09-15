using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorService colorService;
        public ColorsController(IColorService _colorService)
        {
            colorService = _colorService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = colorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Id")]
        public IActionResult GetById(int brandId)
        {
            var result = colorService.GetCarsByColorId(brandId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }





    }
}
