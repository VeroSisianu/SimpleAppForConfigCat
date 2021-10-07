using System;
using ConfigCat.Client;

namespace ConsoleAppForDifferentTasksForWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ConfigCatClient("fonZCPaOsE-In3pUWGiuFw/iOODjnbk1E25YN115wvU7w");
            //client.LogLevel = LogLevel.Debug;
            var newUpdate2021 = client.GetValue("newupdate2021", false);
            Console.WriteLine("newUpdate2021's value from ConfigCat: " + newUpdate2021);

            if (newUpdate2021)
                Console.WriteLine("This block of code should execute when feature flag is on");
            else
                Console.WriteLine("This block of code should execute when feature flag is off");

            client.Dispose();
        }
    }
}