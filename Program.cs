using System;
using Lib;

namespace DotNet_Core_Gererics_And_Hierarchy_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var myAddress = new Address();
            var repo = new AddressRepository();

            repo.save(myAddress);
        }
    }
}
