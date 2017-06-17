using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCheckup.DAL.Models
{
    [Table("Job", Schema = "public")]
    public class JobEntity
    {
        [Key]
        public Guid Id { get; set; }

        public string Profession { get; set; }
    }
}
