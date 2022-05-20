using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Interfaces;

namespace SafariPark.Models
{
    internal class Animal : IAnimal, IPet
    {
        public Animal(bool isDang, double weight, double height, bool isMale, int age, bool ishealthy, string nickname)
        {
            IsDangerous = isDang;
            Weight = weight;
            Height = height;
            IsMale = isMale;
            Age = age;
            IsHealthy = ishealthy;
            NickName = nickname;
        }

        public bool IsDangerous { get; set; }

        public double Weight { get; set; }

        public double Height { get; set; }

        public bool IsMale { get; set; }
        public int Age { get; set; }
        public bool IsHealthy { get; set; }
        public string NickName { get; set; }

        public void Breathe()
        {
            Console.WriteLine("Inhaled");
        }

        public virtual void Eat(double weigth)
        {
            Console.WriteLine("Eating");
        }

        public void Reproduct(IAnimal animal)
        {
            if (((animal.IsMale && IsMale) || (!animal.IsMale && !IsMale)) && !(animal.GetType() == GetType()))
            {
                Console.WriteLine("You can not do it...");
            }
            else
            {
                Console.WriteLine("Censored");
            }
        }

        public void Sleep()
        {
            Console.WriteLine("Snore");
        }
    }
}
