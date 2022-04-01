using Api_Datos.ContactDB;
using Api_Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Servicios;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Contactos.Controllers
{
    
    [Route("api/Contacs")]
    [ApiController]
    public class ContacsController : ControllerBase
    {
        private readonly ContactContext _contactContext;
        public ContacsController(ContactContext contactContext)
        {
            _contactContext = contactContext;
        }
        // GET: api/<ContacsController>
        [HttpGet("GetAllContacts")]
        public async Task<ActionResult<List<Contactos>>> GetAllContacts()
        {
            var ContactsList = _contactContext.Contactos.ToList();
            if (ContactsList == null)
            { return BadRequest(ContactsList); }
            return Ok(ContactsList);
        }

        // GET api/<ContacsController>/5
        [HttpGet("GetContact/{id}")]
        public async Task<ActionResult<Contactos>> GetContact(int id)
        {
            var ContactsList = await _contactContext.Contactos.FindAsync(id);
            if (ContactsList == null)
            { return BadRequest(ContactsList); }
            return Ok(ContactsList);
        }

        // POST api/<ContacsController>
        [HttpPost("AddContact")]
        public async Task<ActionResult<List<Contactos>>> AddContact([FromBody] Contactos contacto)
        {

            _contactContext.Contactos.Add(contacto);
            var result = await _contactContext.SaveChangesAsync();
            var ContactsLists = _contactContext.Contactos.ToList();
            if (result == null)
            { return BadRequest(result); }

            return Ok(ContactsLists);
        }

        // PUT api/<ContacsController>/5
        [HttpPut("UpdateContact/{id}")]
        public async Task<ActionResult<List<Contactos>>> UpdateContact(int id, [FromBody] Contactos contacto)
        {
            var ContactsList = await _contactContext.Contactos.FindAsync(id);

            ContactsList.ContactName = contacto.ContactName;
            ContactsList.ContactLastName = contacto.ContactLastName;
            ContactsList.ContactEmail = contacto.ContactEmail;

            var result = await _contactContext.SaveChangesAsync();


            var ContactsLists = _contactContext.Contactos.ToList();
            if (result == null)
            { return BadRequest(result); }


            return Ok(ContactsLists);
        }

        // DELETE api/<ContacsController>/5
        [HttpDelete("DeleteContact/{id}")]
        public async Task<ActionResult<List<Contactos>>> DeleteContact(int id)
        {
            var ContactsList = await _contactContext.Contactos.FindAsync(id);
            var result = _contactContext.Remove(ContactsList);
            var results = await _contactContext.SaveChangesAsync();
            var ContactsLists = _contactContext.Contactos.ToList();
            if (results == null)
            { return BadRequest(results); }

            return Ok(ContactsLists);
        }
    }
}
