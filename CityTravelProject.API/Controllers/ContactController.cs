using CityTravelProject.BusinessLayer.Abstract;
using CityTravelProject.DtoLayer.CityMapsDtos;
using CityTravelProject.DtoLayer.ContactDtos;
using CityTravelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityTravelProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _contactService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddContact(CreateContactDto createContactsDto)
        {
            Contact contact = new Contact()
            {
                Name = createContactsDto.Name,
                Email = createContactsDto.Email,
                Subject = createContactsDto.Subject,
                Message = createContactsDto.Message,
                Status  = createContactsDto.Status,
            };
            _contactService.TAdd(contact);
            return Ok("Mesaj başarılı bir şekilde gönderilmiştir.");
        }

        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetById(id);
            _contactService.TDelete(value);
            return Ok("Mesaj başarılı bir şekilde silinmiştir.");
        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            Contact contact = new Contact()
            {
                ContactID = updateContactDto.ContactID,
                Name = updateContactDto.Name,
                Email = updateContactDto.Email,
                Subject = updateContactDto.Subject,
                Message = updateContactDto.Message,
                Status = updateContactDto.Status,
            };
            _contactService.TUpdate(contact);
            return Ok("Güncelleme işlemi başarılı bir şekilde gerçekleştirilmiştir.");
        }
    }
}
