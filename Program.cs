using System;

namespace AssignmentThree
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            
            System.Console.WriteLine(date.ToString($"{"MMMM"} {"dd"}, {"yyyy"}"));
            System.Console.WriteLine(date.ToString($"{"yyyy"}.{"MM"}.{"dd"}"));
            System.Console.WriteLine("Day" + date.ToString($" {"dd"} ") + "of " + date.ToString($"{"MMMM"}, {"yyyy"}"));
            System.Console.WriteLine(date.ToString($"Year: {"yyyy"}, ") + "Month:" + date.ToString($"{"MM"}, ") + "Day: " +  date.ToString($"{"dd"}"));
            System.Console.WriteLine(date.ToString($"          {"dddd"}"));
            System.Console.WriteLine(date.ToString($"   {"h"}:{"mm"} {"tt"}          {"dddd"}"));
            System.Console.WriteLine("h:" + date.ToString($"{"h"}, ")+ "m:" + date.ToString($"{"mm"}, ") + "s:" + date.ToString($"{"ss"}"));
            System.Console.WriteLine(date.ToString($"{"yyyy"}.{"MM"}.{"dd"}.{"hh"}.{"mm"}.{"ss"}"));

            double pi = 3.1415;
            System.Console.WriteLine("{0:C2}", pi);
            System.Console.WriteLine(pi.ToString("#.###"));
            
        }
    }
}
