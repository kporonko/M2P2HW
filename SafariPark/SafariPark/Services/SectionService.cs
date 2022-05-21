using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Models;
using SafariPark.Interfaces.Service_interfaces;
using SafariPark.Interfaces;

namespace SafariPark.Services
{
    internal class SectionService : ISectionService
    {
        public ISection[] CreateSections()
        {
            IAnimalService animalService = new AnimalService();
            animalService.CreateAnimals();
            IAnimal[] sectionAnimals = animalService.Assortment;
            ISection section = new Section(1, 100, sectionAnimals);
            return new ISection[] { section };
        }
    }
}
