using CitySearch.Services.Interfaces;
using CitySearch.Services.Services;
using System;
using System.Diagnostics;

namespace CitySearch
{
    class Program
    {

        static void Main(string[] args)
        {
            Stopwatch timePerParse = Stopwatch.StartNew();
            ICityFinder cityFinder = new CityFinder();
            for (var i = 0; i <= 10; i++) {
                
                ICityResult cityResult = cityFinder.Search("BANG");

                timePerParse.Stop();
                Console.WriteLine(timePerParse.Elapsed.Milliseconds);
                timePerParse.Restart();
            }
            Console.ReadLine();
        }
    }
}