using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Interfaces.AnimalGroups.Birds
{
    /// <summary>
    /// Interface for birds that can swim.
    /// </summary>
    internal interface ISwimBird : IBird, ISwimmer, IWalker
    {
    }
}
