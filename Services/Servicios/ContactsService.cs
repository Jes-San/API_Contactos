using Api_Datos.ContactDB;
using Api_Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Servicios
{
    public class ContactsService
    {
        private readonly ContactContext _contactContext;
        public ContactsService(ContactContext contactContext)
        {
            _contactContext = contactContext;
        }

        public async Task<List<Contactos>> GetAllContacts()
        {
            var ContactsList = _contactContext.Contactos.ToList();
            return (ContactsList);
        }

        public async Task<Contactos> GetContact(int id)
        {
            var ContactsList = await _contactContext.Contactos.FindAsync(id);
            return (ContactsList);
        }

        public async Task<List<Contactos>> AddContact(Contactos contacto)
        {
            _contactContext.Contactos.Add(contacto);
            var result = await _contactContext.SaveChangesAsync();


            var ContactsLists = _contactContext.Contactos.ToList();


            return (ContactsLists);
        }

        public async Task<List<Contactos>> UpdateContact(int id, Contactos contacto)
        {
            var ContactsList = await _contactContext.Contactos.FindAsync(id);

            ContactsList.ContactName = contacto.ContactName;
            ContactsList.ContactLastName = contacto.ContactLastName;
            ContactsList.ContactEmail = contacto.ContactEmail;

            var result = await _contactContext.SaveChangesAsync();
            

            var ContactsLists = _contactContext.Contactos.ToList();


            return (ContactsLists);
        }

        public async Task<List<Contactos>> DeleteContact(int id)
        {

            var ContactsList = await _contactContext.Contactos.FindAsync(id);
            var result = _contactContext.Remove(ContactsList);
            var results = await _contactContext.SaveChangesAsync();
            var ContactsLists = _contactContext.Contactos.ToList();

            return (ContactsLists);
        }
    }
}
