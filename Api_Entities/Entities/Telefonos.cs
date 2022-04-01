using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Entities.Entities
{
    public class Telefonos
    {
        [Key]
        public int PhoneId { get; set; }

        [Required]
        public long PhoneNumber { get; set; }

        [Required]
        [ForeignKey("Contactos")]
        public int ContactId { get; set; }
        public Contactos? Contactos { get; set; }
        
    }
}
