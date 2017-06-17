using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCheckup.DAL.Models
{
    [Table("Owner", Schema = "public")]
    public class OwnerEntity
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Zip { get; set; }

        public string PhoneNumber { get; set; }
    }
}
