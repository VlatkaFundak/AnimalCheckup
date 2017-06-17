using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCheckup.Model.Common.Models
{
    /// <summary>
    /// User poco model interface.
    /// </summary>
    public interface IUserPoco
    {
        /// <summary>
        /// Gets or sets the interface.
        /// </summary>
        Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        string Password { get; set; }

    }
}
