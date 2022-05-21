using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Interfaces.Animals.Dogs
{
    internal class JackRusselTerier : Dog
    {
        public JackRusselTerier(bool isDang, double weight, double height, bool isMale, int age, bool ishealthy, string nickname, double hairweight, bool teethchanged, bool iswet)
    : base(isDang, weight, height, isMale, age, ishealthy, nickname, hairweight, teethchanged, iswet)
        {
        }

        public double MaxWeight
        {
            get
            {
                if (IsMale)
                {
                    return 7000;
                }
                else
                {
                    return 6200;
                }
            }
        }

        public double MaxHeight
        {
            get
            {
                if (IsMale)
                {
                    return 30;
                }
                else
                {
                    return 28;
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
