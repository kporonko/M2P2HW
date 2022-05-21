using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Interfaces.AnimalGroups.Mammals;
using SafariPark.Models;

namespace SafariPark.Interfaces.Animals
{
    internal class Dog : Animal, IWalkerMammals, ISoundMakers
    {
        public Dog(bool isDang, double weight, double height, bool isMale, int age, bool ishealthy, string nickname, double hairweight, bool teethchanged, bool iswet)
    : base(isDang, weight, height, isMale, age, ishealthy, nickname)
        {
            HairCoverWeight = hairweight;
            AreTeethChanged = teethchanged;
            IsWet = iswet;
        }

        public double HairCoverWeight { get; set; }
        public bool AreTeethChanged { get; set; }
        public bool IsWet { get; set; }

        public void Bite(IAnimal animal)
        {
            if (!animal.IsHealthy)
            {
                animal = null;
            }
            else
            {
                animal.IsHealthy = false;
            }
        }

        public void MakeSound()
        {
            Console.WriteLine("woof");
        }

        public void Swim()
        {
            IsWet = true;
        }

        public void Think()
        {
        }

        public void Walk()
        {
        }
    }
}
