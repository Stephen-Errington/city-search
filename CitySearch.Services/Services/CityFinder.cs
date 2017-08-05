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

        #region Public Methods

        public ICityResult Search(string searchString) {
            ICollection<string> cities = new Collection<string>();
            ICollection<string> letters = new Collection<string>();

            while (true) {

                searchString = searchString.ToUpper();

                if (string.IsNullOrEmpty(searchString))
                    continue;

                var node = DataSource.Trie.Prefix(searchString);

                if (node.Depth == searchString.Length) {
                    foreach (var suffix in Suffixes(node).Distinct()) {
                        cities.Add(searchString + suffix);

                        if (suffix.Length > 0 && !letters.Contains(suffix.Substring(0, 1)))
                            letters.Add(suffix.Substring(0, 1));
                    }
                }

                return new CityResult(cities, letters);
            }
        }

        #endregion

        #region Private Methods

        private IEnumerable<string> Suffixes(Node parent) {
            var sb = new StringBuilder();
            return Suffixes(parent, sb).Select(suffix => suffix.TrimEnd('$'));
        }

        private IEnumerable<string> Suffixes(Node parent, StringBuilder current) {
            if (parent.IsLeaf()) {
                yield return current.ToString();
            } else {
                foreach (var child in parent.Children) {
                    current.Append(child.Value);

                    foreach (var value in Suffixes(child, current))
                        yield return value;

                    --current.Length;
                }
            }
        }

        #endregion
    }
}
