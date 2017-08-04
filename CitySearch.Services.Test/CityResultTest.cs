//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using CitySearch.Services.Interfaces;
//using CitySearch.Services.Services;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;

//namespace CitySearch.Services.Test
//{
//    [TestClass]
//    public class CityResultTest
//    {
//        [TestMethod]
//        [DataRow("BANG")]
//        public void WithSearchString_ShouldReturn_BANGUI_BANGKOK_BANGALORE(string searchString)
//        {
//            ICollection<string> expectedCities = new Collection<string> {
//                "BANGUI",
//                "BANGKOK",
//                "BANGALORE"
//            };

//            ICollection<string> expectedLetters = new Collection<string>();

//            ICityResult expect = new CityResult(expectedCities, expectedLetters);

//            ICityFinder cityFinder = new CityFinder();
//            ICityResult actual = cityFinder.Search(searchString);

//            Assert.IsTrue(expect.NextCities.SequenceEqual(actual.NextCities));
//        }

//        [TestMethod]
//        [DataRow("BANG")]
//        public void WithSearchString_LetterShouldReturn_U_K_A(string searchString) {
//            ICollection<string> expectedCities = new Collection<string>();

//            ICollection<string> expectedLetters = new Collection<string> {
//                "U",
//                "K",
//                "A"
//            };

//            ICityResult expect = new CityResult(expectedCities, expectedLetters);

//            ICityFinder cityFinder = new CityFinder();
//            ICityResult actual = cityFinder.Search(searchString);

//            Assert.IsTrue(expect.NextLetters.SequenceEqual(actual.NextLetters));
//        }

//        [TestMethod]
//        [DataRow("LA")]
//        public void WithSearchString_CitiesShouldReturn_LAPAZ_LAPLATA_LAGOS(string searchString) {
//            ICollection<string> expectedCities = new Collection<string> {
//                "LA PAZ",
//                "LA PLATA",
//                "LAGOS"
//            };

//            ICollection<string> expectedLetters = new Collection<string>();

//            ICityResult expect = new CityResult(expectedCities, expectedLetters);

//            ICityFinder cityFinder = new CityFinder();
//            ICityResult actual = cityFinder.Search(searchString);

//            Assert.IsTrue(expect.NextCities.SequenceEqual(actual.NextCities));
//        }

//        [TestMethod]
//        [DataRow("LA")]
//        public void WithSearchString_LettersShouldReturn_SPACE_G(string searchString) {
//            ICollection<string> expectedCities = new Collection<string>();

//            ICollection<string> expectedLetters = new Collection<string> {
//                " ",
//                "G"
//            };

//            ICityResult expect = new CityResult(expectedCities, expectedLetters);

//            ICityFinder cityFinder = new CityFinder();
//            ICityResult actual = cityFinder.Search(searchString);

//            Assert.IsTrue(expect.NextLetters.SequenceEqual(actual.NextLetters));
//        }

//        [TestMethod]
//        [DataRow("ZE")]
//        public void WithSearchString_CitiesShouldReturn_Null(string searchString) {
//            ICollection<string> expectedCities = new Collection<string>();

//            ICollection<string> expectedLetters = new Collection<string>();

//            ICityResult expect = new CityResult(expectedCities, expectedLetters);

//            ICityFinder cityFinder = new CityFinder();
//            ICityResult actual = cityFinder.Search(searchString);

//            Assert.IsTrue(expect.NextCities.SequenceEqual(actual.NextCities));
//        }

//        [TestMethod]
//        [DataRow("ZE")]
//        public void WithSearchString_LettersShouldReturn_Null(string searchString) {
//            ICollection<string> expectedCities = new Collection<string>();

//            ICollection<string> expectedLetters = new Collection<string>();

//            ICityResult expect = new CityResult(expectedCities, expectedLetters);

//            ICityFinder cityFinder = new CityFinder();
//            ICityResult actual = cityFinder.Search(searchString);

//            Assert.IsTrue(expect.NextLetters.SequenceEqual(actual.NextLetters));
//        }
//    }
//}
