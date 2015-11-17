﻿// This code is distributed under MIT license. Copyright (c) 2013 George Mamaladze
// See license.txt or http://opensource.org/licenses/mit-license.php

namespace WordFinder.Trie
{
    using System.Collections.Generic;

    public class ConcurrentTrie<TValue> : ConcurrentTrieNode<TValue>, ITrie<TValue>
    {
        public IEnumerable<TValue> Retrieve(string query)
        {
            return this.Retrieve(query, 0);
        }

        public void Add(string key, TValue value)
        {
            this.Add(key, 0, value);
        }
    }
}