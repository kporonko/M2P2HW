using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Interfaces
{
    internal interface IPark
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Square { get; set; }
        public ISection[] Sections { get; set; }
    }
}
