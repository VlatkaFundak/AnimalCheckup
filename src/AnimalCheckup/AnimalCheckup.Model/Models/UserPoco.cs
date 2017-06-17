using AnimalCheckup.Model.Common.Models;
using System;

namespace AnimalCheckup.Model.Models
{
    /// <summary>
    /// User poco model class.
    /// </summary>
    public class UserPoco: IUserPoco
    {
        /// <summary>
        /// Gets or sets the interface.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password { get; set; }
    }
}