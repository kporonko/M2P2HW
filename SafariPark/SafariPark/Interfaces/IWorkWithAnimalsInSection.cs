using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Interfaces
{
    public interface IWorkWithAnimalsInSection
    {
        public int DifferentAnimalsInSectionCount(ISection section);

        public int CountIllAnimalsInSection(ISection section);

        public void FillArrayByIllAnimals(IAnimal[] allAnimals, IAnimal[] illAnimals);
        public void SortAnimalsInSectionByWeight(ISection section);
    }
}
