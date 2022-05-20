using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Interfaces.AnimalGroups.Birds
{
    internal interface IFlyBird : IBird, IFlier, IWalker
    {
    }
}
