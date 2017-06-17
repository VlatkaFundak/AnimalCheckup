using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCheckup.Model.Common.Models
{
    /// <summary>
    /// Job poco model interface.
    /// </summary>
    public interface IJobPoco
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the proffesion.
        /// </summary>
        string Profession { get; set; }
    }
}
