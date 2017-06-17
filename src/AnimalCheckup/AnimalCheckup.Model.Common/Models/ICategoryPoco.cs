using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCheckup.Model.Common.Models
{
    /// <summary>
    /// Category poco model interface.
    /// </summary>
    public interface ICategoryPoco
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }
    }
}
