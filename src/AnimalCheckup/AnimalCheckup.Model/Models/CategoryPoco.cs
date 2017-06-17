using AnimalCheckup.Model.Common.Models;
using System;

namespace AnimalCheckup.Model.Models
{
    /// <summary>
    /// Category poco model class.
    /// </summary>
    public class CategoryPoco: ICategoryPoco
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }
    }
}
