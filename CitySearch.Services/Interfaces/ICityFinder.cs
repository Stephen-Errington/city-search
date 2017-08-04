using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CitySearch.Services.Interfaces
{
    public interface ICityFinder
    {
        ICityResult Search(string searchString);
    }
}
