using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int> combinedSet = [];
        for (int i = 0; i < multiples.Count(); i++)
        {
            int numb = multiples.ElementAt(i);

            if (numb == 0)
                continue;
                
            int multiplier = 1;
            int product = numb;

            while (product < max)
            {
                combinedSet.Add(product);
                multiplier++;
                product = numb * multiplier;
            }
        }

        return combinedSet.Sum();
    }
}