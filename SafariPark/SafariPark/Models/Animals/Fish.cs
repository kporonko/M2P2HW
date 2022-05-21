using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Interfaces;

namespace SafariPark.Models.Animals
{
    internal class Fish : Animal, IFish
    {
        public Fish(bool isDang, double weight, double height, bool isMale, int age, bool ishealthy, string nickname, bool isDec, bool isPred, int finsCnt)
            : base(isDang, weight, height, isMale, age, ishealthy, nickname)
        {
            IsDecorative = isDec;
            IsPredator = isPred;
            FinsCount = finsCnt;
        }

        public bool IsDecorative { get; }

        public bool IsPredator { get; }

        public int FinsCount { get; set; }

        public void ChangeGender()
        {
            if (IsMale)
            {
                IsMale = false;
            }
            else
            {
                IsMale = true;
            }
        }

        public void Swim()
        {
            Console.WriteLine("Swimmin");
        }
    }
}
