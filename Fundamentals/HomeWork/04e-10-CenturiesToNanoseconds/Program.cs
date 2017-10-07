using System;

namespace _04e_10_CenturiesToNanoseconds
{
    using System.Numerics;
    using System.Runtime.Remoting.Metadata.W3cXsd2001;

    class Program
    {
        static void Main(string[] args)
        {
            decimal year = 365.2422M;

            int centuries = Int32.Parse(Console.ReadLine());

            long years = centuries*100;

            long days = (long)(years*year);

            long hours = days*24;

            BigInteger minutes = hours*60;
            BigInteger seconds = minutes*60;
            BigInteger milliseconds = seconds*1000;
            BigInteger microseconds = milliseconds*1000;
            BigInteger nanoseconds = microseconds*1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");

        }
    }
}
