using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Interfaces;

namespace SafariPark
{
    /// <summary>
    /// Phrases that we say to park guests.
    /// </summary>
    internal class ConsolePhrases
    {
        public static void WelcomeToParkMsg(IPark park)
        {
            Console.WriteLine($"Welcome to our park {park.Name} with area {park.Square}sq.km.");
        }

        public static void NumberOfSectionsMsg(IPark park)
        {
            Console.WriteLine($"Our park has {park.Sections.Length} animal sections.\n");
        }

        public static void SectionDescMsg(int i, IPark park)
        {
            Console.WriteLine($"Section {i + 1}:\nSection square: {park.Sections[i].Square}\n\nAnimals:\n");
        }

        public static void AnimalDescMsg(int i, int j, IPark park)
        {
            Console.WriteLine($"Animal: {j + 1}\nAnimal type: {park.Sections[i].Animals[j].GetType().Name}");
        }

        public static void ChooseSectionMsg()
        {
            Console.WriteLine("Choose the section you want to visit:");
        }

        public static void OkLeadSectiomMsg()
        {
            Console.WriteLine("Ok. We will lead you to this section");
        }

        public static void SectionIdMsg(ISection section)
        {
            Console.WriteLine($"Section {section.SectionId}\n");
        }

        public static void ChooseAnimalToFeedMsg()
        {
            Console.WriteLine("Choose the animal which you want to feed");
        }

        public static void NumberDiffBreedsInSectionMsg(ISection section, int res)
        {
            Console.WriteLine($"Number of different breeds in Section {section.SectionId}: {res} breed(s)");
        }
    }
}
