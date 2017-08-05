using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CitySearch.Services.Services;
using CitySearch.Services.Services.Interfaces;
using System.Linq;

namespace CitySearch.Services.UnitTests {
    [TestClass]
    public class CityFinderTests {

        [TestClass]
        public class SetupAssemblyInitializer {
            [AssemblyInitialize]
            public static void AssemblyInit(TestContext context) {
                DataSource.SetData();
            }
        }

        [TestMethod]
        [DataRow("BANGK")]
        public void WithSearchStringBANGK_ShouldReturn_BANGKA_BANGKOK_BANGKOKS(string searchString) {
            ICollection<string> expectedCities = new Collection<string> {
                "BANGKA",
                "BANGKOK",
                "BANGKOKS",
            };

            ICollection<string> expectedLetters = new Collection<string>();

            ICityResult expect = new CityResult(expectedCities, expectedLetters);

            ICityFinder cityFinder = new CityFinder();
            ICityResult actual = cityFinder.Search(searchString);

            Assert.IsTrue(expect.NextCities.SequenceEqual(actual.NextCities));
        }

        [TestMethod]
        [DataRow("BANGK")]
        public void WithSearchStringBANGK_ShouldReturn_A_O(string searchString) {
            ICollection<string> expectedCities = new Collection<string>();

            ICollection<string> expectedLetters = new Collection<string>{
                "A",
                "O",
            };

        ICityResult expect = new CityResult(expectedCities, expectedLetters);

            ICityFinder cityFinder = new CityFinder();
            ICityResult actual = cityFinder.Search(searchString);

            Assert.IsTrue(expect.NextLetters.SequenceEqual(actual.NextLetters));
        }
    }
}
