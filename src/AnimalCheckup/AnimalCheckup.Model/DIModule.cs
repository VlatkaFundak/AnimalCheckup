using AnimalCheckup.Model.Common.Models;
using AnimalCheckup.Model.Models;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalCheckup.Model
{
    public class DIModule : NinjectModule
    {
        /// <summary>
        /// Load dependency injection bindings.
        /// </summary>
        public override void Load()
        {
            Bind<IAnimalPoco>().To<AnimalPoco>();
        }
    }
}
