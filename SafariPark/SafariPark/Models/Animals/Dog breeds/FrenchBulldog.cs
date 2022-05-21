using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Interfaces.Animals.Dogs
{
    internal class FrenchBulldog : Dog, IFinalBreed
    {
        public FrenchBulldog(bool isDang, double weight, double height, bool isMale, int age, bool ishealthy, string nickname, double hairweight, bool teethchanged, bool iswet)
            : base(isDang, weight, height, isMale, age, ishealthy, nickname, hairweight, teethchanged, iswet)
        {
        }

        public double MaxWeight
        {
            get
            {
                if (IsMale)
                {
                    return 15000;
                }
                else
                {
                    return 12000;
                }
            }
        }

        public double MaxHeight
        {
            get
            {
                if (IsMale)
                {
                    return 35;
                }
                else
                {
                    return 32;
                }
            }
        }

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
