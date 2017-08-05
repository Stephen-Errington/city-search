using CitySearch.Services;
using CitySearch.Services.Services;
using CitySearch.Services.Services.Interfaces;
using System;
using System.Diagnostics;
using System.IO;

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

            Console.WriteLine(timePerParse.Elapsed);
        }
    }
}