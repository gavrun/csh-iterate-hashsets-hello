namespace csh_iterate_hashsets_hello;

using System;
using System.Collections.Generic;

public class PowerSetGenerator
{
    public static List<HashSet<string>> PowerSet(List<string> flowers)
    {
        List<HashSet<string>> fragrances = new List<HashSet<string>> { new HashSet<string>() };
        
        foreach (string flower in flowers)
        {
            List<HashSet<string>> newFragrances = new List<HashSet<string>>();

            foreach (HashSet<string> fragrance in fragrances)
            {
                HashSet<string> newFragrance = new HashSet<string>(fragrance);
                newFragrance.Add(flower);
                newFragrances.Add(newFragrance);
            }

            fragrances.AddRange(newFragrances);
        }

        return fragrances;
    }
}
