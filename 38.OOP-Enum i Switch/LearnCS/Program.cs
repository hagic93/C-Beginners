using System;

namespace LearnCS
{
    class Program
    {
        enum Options
        {
            Audio,
            Video,
            Controls
        }

        static void Main(string[] args)
        {
            Options c1 = Options.Controls;
            Console.WriteLine(c1);

            switch (c1)
            {
                case Options.Audio:
                    Console.WriteLine("Audio Settings");
                    break;
                case Options.Video:
                    Console.WriteLine("Video Settings");
                    break;
                case Options.Controls:
                    Console.WriteLine("Controls Settings");
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }
        }
    }
}