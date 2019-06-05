using System;
using System.Collections.Generic;

namespace Challenges
{
    class Program
    {
        public static void Main(string[] args)
        {
            Friend a = new Friend("A");
            Friend b = new Friend("B");
            Friend c = new Friend("C");

            a.AddFriendship(b);
            b.AddFriendship(c);

            //Console.WriteLine(a.CanBeConnected(c));
            Console.WriteLine("MinimalNumberOfPackages: " + Shipping.MinimalNumberOfPackages(16, 2, 10));
            Console.WriteLine("Transform: " + RemoveRepetitions.Transform("abbcbbb"));
        }
    }
}