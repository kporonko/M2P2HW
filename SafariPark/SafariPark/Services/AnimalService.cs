using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Interfaces;
using SafariPark.Interfaces.Animals;
using SafariPark.Interfaces.Animals.Dogs;
using SafariPark.Interfaces.Service_interfaces;
using SafariPark.Models.Animals;

namespace SafariPark.Services
{
    /// <summary>
    /// All the animals in the park.
    /// </summary>
    internal class AnimalService : IAnimalService
    {
        public IAnimal[] Assortment { get; set; } = new IAnimal[10];
        public void CreateAnimals()
        {
            Assortment[0] = new FrenchBulldog(false, 7000, 25, true, 3, true, "Bobik", 100, true, false);
            Assortment[1] = new FrenchBulldog(true, 6000, 23, false, 3, true, "Julia", 80, true, false);
            Assortment[2] = new JackRusselTerier(false, 5000, 25, true, 3, true, "Bobik", 100, true, false);
            Assortment[3] = new JackRusselTerier(true, 7000, 25, false, 2, true, "Jean", 50, true, true);
            Assortment[4] = new DecorativeCarp(false, 1000, 15, true, 1, false, "Nemo", true, false, 6);
            Assortment[5] = new DecorativeCarp(false, 4000, 30, false, 4, true, "Dori", true, false, 6);
            Assortment[6] = new DecorativeCarp(false, 2000, 22, true, 2, true, "Carp22", true, false, 6);
            Assortment[7] = new Calibri(false, 40, 4, false, 1, true, "Cola", true);
            Assortment[8] = new Calibri(false, 20, 3, true, 1, true, "Cole", true);
            Assortment[9] = new Calibri(false, 30, 3, true, 1, true, "Coli", true);
        }
    }
}
