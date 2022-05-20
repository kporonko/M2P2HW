using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Interfaces
{
    internal interface ISection
    {
        double Square { get; set; }
        IAnimal[] Animals { get; set; }
        public int SectionId { get; }
    }
}
