using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CitySearch.Services {
    public static class DataSource {
        private static readonly Trie _trie = new Trie();

        public static void SetData() {
            _trie.InsertRange(File.ReadLines("../Cities.txt").OrderBy(x => x));
        }

        public static Trie Trie { get { return _trie; } }
    }
}
