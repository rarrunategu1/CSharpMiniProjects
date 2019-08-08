using System;

namespace IntermediateExercises
{
    public class Stopwatch
    {
        public DateTime Start { get; set; }

        //provide method to start the stopwatch
        public void StartTime()
        {
            Console.WriteLine(Start);
        }

        //provide method to stop the stopwatch

        //duration between start and stop in TimeSpand

        //diplay duration on the console

        //should be able to use stopwatch multiple times

        //class should throw and Invalid Operation Exception if it's started twice in a row    }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch() { Start = DateTime.Now };
            stopWatch.StartTime();
     
        }
    }
}
