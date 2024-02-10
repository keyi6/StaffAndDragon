using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Game
{
    public static class Element
    {
        public enum Types
        {
            Fire,
            Water,
            Stone,
            Wind,
            Thunder,
        }

        public static Dictionary<string, Types> ELEMENT_MAPPING = new Dictionary<string, Types>
        {
            { "Fire", Types.Fire },
            { "Water", Types.Water },
            { "Stone", Types.Stone },
            { "Wind", Types.Wind },
            { "Thunder", Types.Thunder },
        };

        public static Dictionary<Types, string> TEXT_MAPPING = new Dictionary<Types, string>
        {
            { Types.Fire, "Fire" },
            { Types.Water, "Water" },
            { Types.Stone, "Stone" },
            { Types.Wind, "Wind" },
            { Types.Thunder, "Thunder" },
        };


        private static List<Types> elements = new List<Types>(); 

        public static string GetDisplayString()
        {
            return elements
                .Select(el => TEXT_MAPPING[el])
                .Aggregate((a, b) => a + " " + b);
        }

        public static void AddElement(string s)
        {
            Types el = ELEMENT_MAPPING[s];
            elements.Add(el);

            if (elements.Count > 2)
            {
                elements.RemoveAt(0);
            }
        }
    }
}