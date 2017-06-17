using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCheckup.Model.Common.Models
{
    /// <summary>
    /// Owner poco model interface.
    /// </summary>
    public interface IOwnerPoco: IAddressModel
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
        /// Gets or sets the phone number.
        /// </summary>
        string PhoneNumber { get; set; }
    }
}
