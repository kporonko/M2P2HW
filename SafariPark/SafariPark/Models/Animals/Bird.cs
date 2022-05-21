using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Interfaces;

namespace SafariPark.Models.Animals
{
    internal class Bird : Animal, IBird
    {
        public Bird(bool isDang, double weight, double height, bool isMale, int age, bool ishealthy, string nickname, bool isFeather)
                   : base(isDang, weight, height, isMale, age, ishealthy, nickname)
        {
            IsFeather = isFeather;
        }

        public bool IsFeather { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine();
        }

        public void Think()
        {
        }
    }
}
