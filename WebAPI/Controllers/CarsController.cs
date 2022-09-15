using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    //Katmanımız için gerekli referanslandırmayı yapalım.
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        //Şimdi öncellikler bağımlılığı ortadan kaldırmak için
        //kaldırmak değilde bağımlılığı en aza indirgeme için 
        //yapımızı oluşturalım.
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
            //Bu yapı sayesinde bağımlılık seviyemzizi en aza indirgemiş olduk.
        }
        
        [HttpGet("getAll")]//Bu komut swagger arayüzünde sadece get etme işlemi yapacağımızı tanımlamamıza yarar.
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result );
            }
            
            return BadRequest(result);

            
        }

    }
}
