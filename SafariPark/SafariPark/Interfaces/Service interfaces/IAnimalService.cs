using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Interfaces.Service_interfaces
{
    internal interface IAnimalService
    {
        public IAnimal[] Assortment { get; set; }
        public void CreateAnimals();
    }
}
