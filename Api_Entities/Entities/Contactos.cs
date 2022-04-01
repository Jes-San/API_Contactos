using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Entities.Entities
{
    public class Contactos
    {
        [Key]
        public int ContactId { get; set; }

        [Required]
        public string ContactName { get; set; } = string.Empty;

        [Required]
        public string ContactLastName { get; set; } = string.Empty;

        [Required]
        public string ContactEmail { get; set; } = string.Empty;

        /*
        [Required]
        public long PhoneNumber { get; set; }
        
        [Required]
        public List<Telefonos>? PhoneNumber { get; set; }
        */
    }
}
