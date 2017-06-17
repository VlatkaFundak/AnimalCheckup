using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCheckup.DAL.Models
{
    [Table("Animal", Schema = "public")]
    public class AnimalEntity
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string Remarks { get; set; }

        public int ChipNumber { get; set; }

        public Guid OwnerId { get; set; }

        public CategoryEntity Category { get; set; }
    }
}
