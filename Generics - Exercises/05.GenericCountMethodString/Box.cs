﻿namespace _05.GenericCountMethodString
{
    using System.Collections.Generic;

    public class Box<T>
    {
        public List<T> Data { get; set; } = new List<T>();

        public void Add(T value)
        {
            this.Data.Add(value);
        }
    }
}
