using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCheckup.Model.Common.Models
{
    /// <summary>
    /// User profile poco model interface.
    /// </summary>
    public interface IUserProfilePoco
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
        /// Gets or sets the surname.
        /// </summary>
        string Surname { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// Gets or sets the job.
        /// </summary>
        IJobPoco Job { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        IUserPoco User { get; set; }
    }
}
