using System;

namespace a2p4_ashleybanton_sd
{
    class Program
    {

        public enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        enum storedmonths
        {

        }
        static void Main(string[] args)
        {
            bool looping = true;

            while(looping)
            {
                string userinput;

                foreach (var v in Enum.GetValues(typeof(Months)))
                {
                    Console.WriteLine(v);
                }

                Console.WriteLine("Put your month of birth in:");
                userinput = Console.ReadLine();

                Months month;
                if (Enum.TryParse<Months>($"{userinput}", out month))
                {
                    Console.WriteLine("Your month is: " +userinput+ "");
                    looping = false;
                }
                else
                {
                    Console.WriteLine("Fail! Invalid month input: " + userinput + "");
                    looping = true;
                }
            }
        }
    }
}
