using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Interfaces.AnimalGroups.Mammals
{
    /// <summary>
    /// Interface for mammals that can walk and also swim (by default).
    /// </summary>
    internal interface IWalkerMammals : IMammal, IWalker, ISwimmer
    {
    }
}
