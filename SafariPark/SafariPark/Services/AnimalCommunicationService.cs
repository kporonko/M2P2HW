using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Interfaces;

namespace SafariPark.Services
{
    /// <summary>
    /// Park guests can communicate with animals - feed them.
    /// </summary>
    internal class AnimalCommunicationService : ICommunicateAnimal
    {
        public void Communicate(IAnimal animal)
        {
            Console.WriteLine($"{animal.GetType().Name} {animal.NickName}");
            Console.WriteLine($"Weight:{animal.Weight} Height:{animal.Height}");
            animal.Eat(20);
            Console.WriteLine($"Weight:{animal.Weight} Height:{animal.Height}");
        }
    }
}
