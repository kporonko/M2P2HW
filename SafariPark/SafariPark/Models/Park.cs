using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Interfaces;

namespace SafariPark.Models
{
    internal class Park
    {
        public Park(int id, string name, double sq, ISection[] sections)
        {
            Id = id;
            Name = name;
            Square = sq;
            Sections = sections;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Square { get; set; }
        public ISection[] Sections { get; set; }
    }
}
