using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalCheckup.DAL.Models
{
    [Table("User", Schema = "public")]
    public class User
    {
        [Column("ID")]
        [Key]
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}