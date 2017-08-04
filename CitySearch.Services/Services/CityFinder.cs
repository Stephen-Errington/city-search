using CitySearch.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CitySearch.Services.Services {
    public class CityFinder : ICityFinder {

        #region DataSource

        public CityFinder() {
            _cityDataSource = File.ReadAllLines("../Cities.txt").ToArray();
        }

        private readonly string[] _cityDataSource;

        #endregion

        #region Public Methods

        public ICityResult Search(string searchString) {
            searchString = searchString.ToLower();

            ICollection<string> cities = SearchCities(searchString);

            ICollection<string> letters = FilterLetters(cities, searchString);

            return new CityResult(cities, letters);
        }

        #endregion

        #region Private Methods

        private ICollection<string> SearchCities(string searchString) {
            return _cityDataSource.AsParallel().Where(x => x.ToLower().StartsWith(searchString)).ToArray();
        }

        private ICollection<string> FilterLetters(ICollection<string> cities, string searchString) {
            return cities.Select(c => c.Substring(searchString.Length, 1)).Distinct().ToArray();
        }

        #endregion
    }
}
