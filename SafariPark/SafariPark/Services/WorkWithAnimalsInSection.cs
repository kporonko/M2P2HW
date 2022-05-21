using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Interfaces;

namespace SafariPark
{
    /// <summary>
    /// Class contains methods that do some actions with animals in section.
    /// </summary>
    public class WorkWithAnimalsInSection : IWorkWithAnimalsInSection
    {
        public int DifferentAnimalsInSectionCount(ISection section)
        {
            string[] diffTypes = new string[section.Animals.Length];
            for (int i = 0; i < section.Animals.Length; i++)
            {
                diffTypes[i] = section.Animals[i].GetType().Name;
            }

            return diffTypes.Distinct().Count();
        }

        /// <summary>
        /// Method counts all ill animals in section. Done for class MyExtensions.
        /// </summary>
        /// <param name="section">Section of animals.</param>
        /// <returns>Number of ill animals in this section.</returns>
        public int CountIllAnimalsInSection(ISection section)
        {
            int res = 0;
            for (int i = 0; i < section.Animals.Length; i++)
            {
                if (section.Animals[i].IsHealthy == false)
                {
                    res++;
                }
            }

            return res;
        }

        /// <summary>
        /// Fills the array by ill animals in section.
        /// </summary>
        /// <param name="allAnimals">All animals of section.</param>
        /// <param name="illAnimals">Array of ill animals (Enters empty).</param>
        public void FillArrayByIllAnimals(IAnimal[] allAnimals, IAnimal[] illAnimals)
        {
            int j = 0;
            for (int i = 0; i < allAnimals.Length; i++)
            {
                if (allAnimals[i].IsHealthy == false)
                {
                    illAnimals[j] = allAnimals[i];
                    j++;
                }
            }
        }

        public void SortAnimalsInSectionByWeight(ISection section)
        {
            IAnimal[] newSortedArr = section.Animals.OrderBy(x => x.Weight).ToArray();
            section.Animals = newSortedArr;
        }
    }
}
