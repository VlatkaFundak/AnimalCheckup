using AnimalCheckup.Model.Common.Models;
using System;

namespace AnimalCheckup.Model.Models
{
    /// <summary>
    /// User profile poco model class.
    /// </summary>
    public class UserProfilePoco: IUserProfilePoco
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
        /// Gets or sets the surname.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the job.
        /// </summary>
        public IJobPoco Job { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        public IUserPoco User { get; set; }
    }
}
