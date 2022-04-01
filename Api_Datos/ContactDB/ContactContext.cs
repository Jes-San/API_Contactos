using Api_Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Datos.ContactDB
{
    public class ContactContext : DbContext
    {
        public ContactContext (DbContextOptions<ContactContext> dbOptions) : base (dbOptions) {  }

        public DbSet<Contactos> Contactos { get; set; }
        public DbSet<Telefonos> Telefonos { get; set; }
    }
}
