﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;

using static System.Console;

namespace WorkingWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new List<string>();

            cities.Add("London");
            cities.Add("Paris");
            cities.Add("Milan");
            cities.Add("Belgrade");

            WriteLine("Initial list");

            foreach (string city in cities)
            {
                WriteLine($" {city}");
            }

            WriteLine($"The first city is {cities[0]}");
            WriteLine($"The last city is {cities[cities.Count - 1]}.");

            cities.Insert(0, "Sydney");

            WriteLine("After inserting Sydney at index 0");

            foreach (string city in cities)
            {
                WriteLine($" {city}");
            }

            cities.RemoveAt(1);

            cities.Remove("Milan");

            WriteLine("After removing two cities");

            foreach (string city in cities)
            {
                WriteLine($" {city}");
            }


            var immutablesCities = cities.ToImmutableList();

            var newList = immutablesCities.Add("Rio");

            Write("Immutable list of cities:");

            foreach (string city in immutablesCities)
            {
                WriteLine($" {city}");
            }

            WriteLine();

            Write("New list of cities:");

            foreach (string city in newList)
            {
                WriteLine($" {city}");
            }

            WriteLine();

        }
    }
}
