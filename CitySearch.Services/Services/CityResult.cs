using CitySearch.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitySearch.Services.Services {
    public class CityResult : ICityResult {
        public CityResult(ICollection<string> nextCities, ICollection<string> nextLetters) {
            NextCities = nextCities;
            NextLetters = nextLetters;
        }

        public ICollection<string> NextCities { get; set; }
        public ICollection<string> NextLetters { get; set; }
    }
}
