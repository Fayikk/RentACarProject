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

        

    }
}
