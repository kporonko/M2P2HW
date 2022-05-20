using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Interfaces;

namespace SafariPark.Models.Animals
{
    internal class DecorativeCarp : Fish, IFish, IFinalBreed
    {
        public DecorativeCarp(bool isDang, double weight, double height, bool isMale, int age, bool ishealthy, string nickname, bool isDec, bool isPred, int finsCnt)
            : base(isDang, weight, height, isMale, age, ishealthy, nickname, isDec, isPred, finsCnt)
        {
        }

        public double MaxWeight { get; } = 7000;

        public double MaxHeight { get; } = 35;
        public override void Eat(double weigth)
        {
            base.Eat(weigth);
            if (MaxWeight < Weight + weigth)
            {
                Weight = MaxWeight;
            }
            else
            {
                Weight += weigth;
            }

            if (Height < MaxHeight)
            {
                Height++;
            }
        }
    }
}
