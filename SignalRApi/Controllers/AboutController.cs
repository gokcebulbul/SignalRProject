using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        [HttpGet]
        public IActionResult AboutList()
        {
            var values= _aboutService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto _createAboutDto)
        {
            About about = new About()
            {
                Title = _createAboutDto.Title,
                Description = _createAboutDto.Description,
                ImageUrl = _createAboutDto.ImageUrl,
            };
            _aboutService.TAdd(about);
            return Ok("Hakkımda Kısmı Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutService.TGetByID(id);
            _aboutService.TDelete(values);
            return Ok("Hakkımda Alanı Silindi");
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto _updateAboutDto)
        {
            About about = new About()
            {
                AboutID = _updateAboutDto.AboutID,
                Title = _updateAboutDto.Title,
                ImageUrl = _updateAboutDto.ImageUrl,
                Description = _updateAboutDto.Description,
            };
            _aboutService.TUpdate(about);
            return Ok("Hakkımda Kısmı Başarılı Bir Şekilde Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var value = _aboutService.TGetByID(id);
            return Ok(value);
        }
    }
}
