using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Interfaces;
using SafariPark.Services;

namespace SafariPark
{
    internal class Starter
    {
        public static void Run()
        {
            ParkService parkService = new ParkService();
            parkService.CreatePark();
            UserCommunication.Welcome(parkService.Park);
            UserCommunication.SectionsCount(parkService.Park);
            UserCommunication.SectionsDescription(parkService.Park);

            ISection section = UserCommunication.ChooseSection(parkService.Park);
            UserCommunication.SectionAnimalsDescription(section);
            IAnimal animalToCommunicate = UserCommunication.ChooseAnimalToCommunicateWith(section);
            AnimalCommunicationService animalCommunicationService = new AnimalCommunicationService();
            animalCommunicationService.Communicate(animalToCommunicate);
            UserCommunication.SayNumberOfDifferentBreeds(section);

            IWorkWithAnimalsInSection workWithAnimalsInSection = new WorkWithAnimalsInSection();

            // Myextension finds ill animals in section.
            IAnimal[] illAnimals = MyExtentions.FindIllAnimalsInSection(workWithAnimalsInSection, section);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < illAnimals.Length; i++)
            {
                AnimalToStringService.AnimalToString(illAnimals, i, ref sb);
            }

            Console.WriteLine("\nIll animals in section:\n" + sb);

            // Sorting animals by weight.
            workWithAnimalsInSection.SortAnimalsInSectionByWeight(section);
            StringBuilder sb2 = new StringBuilder();
            for (int i = 0; i < section.Animals.Length; i++)
            {
                AnimalToStringService.AnimalToString(section.Animals, i, ref sb2);
            }

            Console.WriteLine("\nSorted animals in section:\n" + sb2);
        }
    }
}
