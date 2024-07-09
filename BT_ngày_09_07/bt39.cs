using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        List<string> albums = new List<string>() { "Red", "Midnight", "Reputation" };

        for (int i = 0; i < albums.Count; i++)
        {
            Console.WriteLine(albums[i]);
        }
    }
}
