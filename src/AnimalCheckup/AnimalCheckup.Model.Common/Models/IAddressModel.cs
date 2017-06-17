using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCheckup.Model.Common.Models
{
    /// <summary>
    /// Address common model class.
    /// </summary>
    public interface IAddressModel
    {
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        string Address { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        string City { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        string Country { get; set; }

        /// <summary>
        /// Gets or sets the zip code.
        /// </summary>
        string Zip { get; set; }
    }
}
