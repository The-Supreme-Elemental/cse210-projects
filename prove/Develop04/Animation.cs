using System;
using System.Runtime.InteropServices;

public abstract class Animation
{


    static void Main(string[] args) 
    {
        while(true)
        {
            int delay = 100;
            Console.Write("/\b");
            Thread.Sleep(delay);
            Console.Write("|\b");
            Thread.Sleep(delay);
            Console.Write("\\\b");
            Thread.Sleep(delay);
            Console.Write("-\b");
            Thread.Sleep(delay);
        }
    }

}