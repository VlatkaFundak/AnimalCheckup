using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCheckup.DAL.Models
{
    [Table("UserProfile", Schema = "public")]
    public class UserProfileEntity
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public JobEntity Job { get; set; }

        public UserEntity User { get; set; }
    }
}
