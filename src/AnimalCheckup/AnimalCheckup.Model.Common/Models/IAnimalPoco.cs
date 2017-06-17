using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCheckup.Model.Common.Models
{
    /// <summary>
    /// Animal poco model interface.
    /// </summary>
    public interface IAnimalPoco
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the birth date.
        /// </summary>
        DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the remarks.
        /// </summary>
        string Remarks { get; set; }

        /// <summary>
        /// Gets or sets the chip number.
        /// </summary>
        int ChipNumber { get; set; }

        /// <summary>
        /// Gets or sets the owner.
        /// </summary>
        IOwnerPoco Owner { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        ICategoryPoco Category { get; set; }
    }
}
