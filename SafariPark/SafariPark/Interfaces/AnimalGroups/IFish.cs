using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Interfaces
{
    internal interface IFish : IAnimal, ISwimmer
    {
        public bool IsDecorative { get; }
        public bool IsPredator { get; }
        public int FinsCount { get; set; }
        public void ChangeGender();
    }
}
