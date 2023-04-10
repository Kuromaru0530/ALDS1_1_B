using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var Input = Console.ReadLine().Split(' ');
        var x = int.Parse(Input[0]);
        var y = int.Parse(Input[1]);

        if (x < y)
        {
            (x, y) = (y, x);
        }

        while (y > 0)
        {
            int r = x % y;
            x = y;
            y = r;
        }
        Console.WriteLine(x);
    }
}
