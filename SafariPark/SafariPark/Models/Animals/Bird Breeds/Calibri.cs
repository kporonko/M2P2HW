using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Interfaces.AnimalGroups.Birds;
using SafariPark.Models;
using SafariPark.Models.Animals;

namespace SafariPark.Interfaces.Animals
{
    internal class Calibri : Bird, IFlyBird, IFinalBreed, ISoundMakers
    {
        public Calibri(bool isDang, double weight, double height, bool isMale, int age, bool ishealthy, string nickname, bool isFeather)
            : base(isDang, weight, height, isMale, age, ishealthy, nickname, isFeather)
        {
        }

        public double MaxWeight { get; } = 80;

        public double MaxHeight { get; } = 5;

        public void Fly()
        {
            Console.WriteLine("Flying");
        }

        public override void MakeSound()
        {
            Console.WriteLine("aaaaaa");
        }

        public void Walk()
        {
        }
    }
}
