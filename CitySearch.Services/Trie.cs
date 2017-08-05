using CitySearch.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CitySearch.Services {
    public class Trie {
        readonly Node _root;

        public Trie() {
            _root = new Node('^', 0, null);
        }

        public Node Prefix(string text) {
            var currentNode = _root;
            var result = currentNode;

            foreach (var letter in text) {
                currentNode = currentNode.FindChildNode(letter);

                if (currentNode == null)
                    break;

                result = currentNode;
            }

            return result;
        }

        public void InsertRange(IEnumerable<string> items) {
            foreach (string item in items)
                Insert(item.ToUpper());
        }

        public void Insert(string text) {
            var commonPrefix = Prefix(text);
            var current = commonPrefix;

            for (var i = current.Depth; i < text.Length; i++) {
                var newNode = new Node(text[i], current.Depth + 1, current);
                current.Children.Add(newNode);
                current = newNode;
            }

            current.Children.Add(new Node('$', current.Depth + 1, current));
        }
    }
}