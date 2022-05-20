using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Interfaces.AnimalGroups.Mammals
{
    /// <summary>
    /// Interface for mammals that can swim.
    /// </summary>
    internal interface ISwimmerMammals : IMammal, ISwimmer
    {
    }
}
