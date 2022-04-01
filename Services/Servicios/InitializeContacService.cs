using Api_Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Servicios
{
    public class InitializeContacService
    {
        ContactsService _contactsService;

        public InitializeContacService(ContactsService contactsService)
        {
            _contactsService = contactsService;
        }

        public  Task<List<Contactos>> GetAllContacts()
        {
            var ContactsList = _contactsService.GetAllContacts();
            return (ContactsList);
        }

        public async Task<Contactos> GetContact(int id)
        {
            var ContactsList = await _contactsService.GetContact(id);
            return (ContactsList);
        }

        public Task<List<Contactos>> AddContact(Contactos contacto)
        {
            var ContactsLists = _contactsService.AddContact(contacto);


            return (ContactsLists);
        }

        public Task<List<Contactos>> UpdateContact(int id, Contactos contacto)
        {
            var ContactsLists = _contactsService.UpdateContact(id, contacto);


            return (ContactsLists);
        }

        public async Task<List<Contactos>> DeleteContact(int id)
        {

            var ContactsLists = await _contactsService.DeleteContact(id);

            return (ContactsLists);
        }

    }
}
