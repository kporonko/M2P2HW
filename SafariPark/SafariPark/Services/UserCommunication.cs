using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Interfaces;
using SafariPark.Interfaces.Animals;
using SafariPark.Models.Animals;

namespace SafariPark
{
    /// <summary>
    /// Using phrases that we can say to users. (done according to srp).
    /// </summary>
    internal class UserCommunication
    {
        public static void Welcome(IPark park)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            ConsolePhrases.WelcomeToParkMsg(park);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void SectionsCount(IPark park)
        {
            ConsolePhrases.NumberOfSectionsMsg(park);
        }

        public static void SectionsDescription(IPark park)
        {
            for (int i = 0; i < park.Sections.Length; i++)
            {
                ConsolePhrases.SectionDescMsg(i, park);
                for (int j = 0; j < park.Sections[i].Animals.Length; j++)
                {
                    Type type = park.Sections[i].Animals[j].GetType();
                    var currAnimal = park.Sections[i].Animals[j];
                    ConsolePhrases.AnimalDescMsg(i, j, park);
                }

                Console.WriteLine();
            }
        }

        public static ISection ChooseSection(IPark park)
        {
            ConsolePhrases.ChooseSectionMsg();
            string res = Console.ReadLine();
            int sectNum = Convert.ToInt32(res) - 1;
            Console.ForegroundColor = ConsoleColor.Yellow;
            ConsolePhrases.OkLeadSectiomMsg();
            Console.ForegroundColor = ConsoleColor.White;
            return park.Sections[sectNum];
        }

        public static void SectionAnimalsDescription(ISection section)
        {
            ConsolePhrases.SectionIdMsg(section);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < section.Animals.Length; i++)
            {
                AnimalToStringService.AnimalToString(section.Animals, i, ref sb);
            }

            Console.WriteLine(sb);
        }

        public static IAnimal ChooseAnimalToCommunicateWith(ISection section)
        {
            ConsolePhrases.ChooseAnimalToFeedMsg();
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            return section.Animals[index];
        }

        public static void SayNumberOfDifferentBreeds(ISection section)
        {
            WorkWithAnimalsInSection workWithAnimalsInSection = new WorkWithAnimalsInSection();
            int res = workWithAnimalsInSection.DifferentAnimalsInSectionCount(section);
            Console.WriteLine($"Number of different breeds in Section {section.SectionId}: {res} breed(s)");
        }
    }
}
