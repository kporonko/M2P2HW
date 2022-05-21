using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Interfaces;
using SafariPark.Models;

namespace SafariPark.Services
{
    internal class ParkService
    {
        public IPark Park { get; set; }
        public void CreatePark()
        {
            ISectionService sectionService = new SectionService();
            ISection[] sections = sectionService.CreateSections();
            Park = new Park(1, "Safari", 10000, sections);
        }
    }
}
