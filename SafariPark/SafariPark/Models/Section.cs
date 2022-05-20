using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Interfaces;

namespace SafariPark.Models
{
    internal class Section : ISection
    {
        public double Square { get; set; }
        public IAnimal[] Animals { get; set; }

        public int SectionId { get; }
    }
}
