using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Interfaces;

namespace SafariPark
{
    public static class MyExtentions
    {
        public static IAnimal[] FindIllAnimalsInSection(this IWorkWithAnimalsInSection workWithAnimalsInSection, ISection section)
        {
            IWorkWithAnimalsInSection workWithAnimalsInSection1 = workWithAnimalsInSection;
            IAnimal[] illAnimals = new IAnimal[workWithAnimalsInSection.CountIllAnimalsInSection(section)];
            workWithAnimalsInSection.FillArrayByIllAnimals(section.Animals, illAnimals);
            return illAnimals;
        }
    }
}
