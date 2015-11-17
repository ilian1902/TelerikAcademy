﻿namespace WordFinder
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface to be implemented by a data structure 
    /// which allows adding values <see cref="TValue"/> associated with <b>string</b> keys.
    /// The interface allows retrieveal of multiple values 
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    public interface ITrie<TValue>
    {
        IEnumerable<TValue> Retrieve(string query);

        void Add(string key, TValue value);
    }
}
