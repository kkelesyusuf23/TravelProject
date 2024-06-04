using CityTravelProject.BusinessLayer.Abstract;
using CityTravelProject.DtoLayer.ContactDtos;
using CityTravelProject.DtoLayer.ContactInformationDtos;
using CityTravelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityTravelProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactInformationController : ControllerBase
    {
        private readonly IContactInformationService _contactInformationService;

        public ContactInformationController(IContactInformationService contactInformationService)
        {
            _contactInformationService = contactInformationService;
        }

        [HttpGet]
        public IActionResult ContactInformationList()
        {
            var values = _contactInformationService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddContactInformation(CreateContactInformationDto createContactInformationDto)
        {
            ContactInformation contactInformation = new ContactInformation()
            {
                Icon = createContactInformationDto.Icon,
                Description = createContactInformationDto.Description,
                MapURL = createContactInformationDto.MapURL,
                Status = createContactInformationDto.Status,
            };
            _contactInformationService.TAdd(contactInformation);
            return Ok("İletişim bilgisi başarılı bir şekilde eklenmiştir.");
        }

        [HttpDelete]
        public IActionResult DeleteContactInformation(int id)
        {
            var value = _contactInformationService.TGetById(id);
            _contactInformationService.TDelete(value);
            return Ok("İletişim bilgisi başarılı bir şekilde silinmiştir.");
        }

        [HttpGet("{id}")]
        public IActionResult GetContactInformation(int id)
        {
            var value = _contactInformationService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateContactInformation(UpdateContactInformationDto updateContactInformationDto)
        {
            ContactInformation contactInformation = new ContactInformation()
            {
                ContactInformationID = updateContactInformationDto.ContactInformationID,
                Icon = updateContactInformationDto.Icon,
                Description = updateContactInformationDto.Description,
                MapURL = updateContactInformationDto.MapURL,
                Status = updateContactInformationDto.Status,
            };
            _contactInformationService.TUpdate(contactInformation);
            return Ok("Güncelleme işlemi başarılı bir şekilde gerçekleştirilmiştir.");
        }
    }
}
