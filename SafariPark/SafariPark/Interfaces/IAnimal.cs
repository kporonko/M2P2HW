using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Interfaces
{
    internal interface IAnimal
    {
        bool IsDangerous { get; }
        public double Weight { get; }
        public double Height { get; }
        bool IsMale { get; }
        int Age { get; set; }
        bool IsHealthy { get; set; }
        public void Eat(double weigth);
        public void Sleep();
        public void Breathe();
        public void Reproduct(IAnimal animal);
    }
}
