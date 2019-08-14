using System;

namespace IntermediateExercises
{
    public class Stopwatch
    {
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }

        //provide method to start the stopwatch
        public void StartTime()
        {
            Console.WriteLine(Start);
        }

        //provide method to stop the stopwatch
        public void StopTime()
        {
            Console.WriteLine(Stop);
        }

        //duration between start and stop in TimeSpand

        //diplay duration on the console

        //should be able to use stopwatch multiple times

        //class should throw and Invalid Operation Exception if it's started twice in a row    }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("To start the stopwatch simply enter 'start' or Press enter to escape the program: ");
                string startInput = Console.ReadLine();

               
                if (startInput == "start")
                { 
                    Stopwatch stopwatch = new Stopwatch() { Start = DateTime.Now };
                    stopwatch.StartTime();
                    break;
                }
                else if (startInput == "stop")
                {   
                    Console.WriteLine("You must start the stopwatch before you stop it.");
                    Console.WriteLine();
                    continue;
                
                }
                else if (String.IsNullOrWhiteSpace(startInput))
                {
                    return;
                }
            }

            while (true)
            {
                Console.WriteLine("Enter 'stop' to stop your time: ");
                string stopInput = Console.ReadLine();

                if (stopInput == "stop")
                {
                    Stopwatch stopWatch = new Stopwatch() { Stop = DateTime.Now };
                    stopWatch.StopTime();
                    break;
                }
                else if (stopInput == "start")
                {
                    throw new System.InvalidOperationException("Invalid input.  The stopwatch has already been started");
                
                }
                else if (String.IsNullOrWhiteSpace(stopInput))
                {
                    return;
                }
            }

        }
    }
}
