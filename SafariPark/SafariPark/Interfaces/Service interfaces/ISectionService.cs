using SafariPark.Interfaces;

namespace SafariPark.Services
{
    internal interface ISectionService
    {
        /// <summary>
        /// Creates sections in the park.
        /// </summary>
        /// <returns>ISection array of created sections.</returns>
        public ISection[] CreateSections();
    }
}