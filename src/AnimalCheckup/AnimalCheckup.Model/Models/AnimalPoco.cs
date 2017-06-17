using AnimalCheckup.Model.Common.Models;
using AnimalCheckup.Model.Models;
using System;

namespace AnimalCheckup.Model.Models
{
    /// <summary>
    /// Animal poco model class.
    /// </summary>
    public class AnimalPoco : IAnimalPoco
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the birth date.
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the remarks.
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// Gets or sets the chip number.
        /// </summary>
        public int ChipNumber { get; set; }

        /// <summary>
        /// Gets or sets the owner.
        /// </summary>
        public IOwnerPoco Owner { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        public ICategoryPoco Category { get; set; }
    }
}
