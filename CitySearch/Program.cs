using CitySearch.Services;
using CitySearch.Services.Interfaces;
using CitySearch.Services.Services;
using System;
using System.Diagnostics;

namespace CitySearch {
    public class Program {

        static void Main(string[] args) {
            DataSource.SetData();

            string searchString = Console.ReadLine();
            Search(searchString);

            Console.ReadLine();
        }

        static void Search(string searchString) {
            Stopwatch timePerParse = Stopwatch.StartNew();
            ICityFinder cityFinder = new CityFinder();
            ICityResult cityResult = cityFinder.Search(searchString);

            timePerParse.Stop();

            foreach (var item in cityResult.NextCities) {
                Console.WriteLine(item);
            }

            Console.WriteLine(timePerParse.Elapsed);
        }
    }
}