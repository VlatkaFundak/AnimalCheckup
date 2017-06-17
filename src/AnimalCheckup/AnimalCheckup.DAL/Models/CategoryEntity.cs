using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCheckup.DAL.Models
{
    [Table("Category", Schema = "public")]
    public class CategoryEntity
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
