using AnimalCheckup.Model.Common.Models;
using System;

namespace AnimalCheckup.Model.Models
{
    /// <summary>
    /// Job poco model class.
    /// </summary>
    public class JobPoco: IJobPoco
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the proffesion.
        /// </summary>
        public string Profession { get; set; }
    }
}
