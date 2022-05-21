using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Interfaces
{
    internal interface IMammal : IAnimal, IIntelligence
    {
        public double HairCoverWeight { get; }
        public bool AreTeethChanged { get; set; }
        bool IsWet { get; set; }
        public void Bite(IAnimal animal);
        public void MakeSound();
    }
}
