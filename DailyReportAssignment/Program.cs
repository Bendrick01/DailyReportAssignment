﻿using System;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine ("What Page Number?");
            int page = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer\"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool needHelpBool = bool.Parse(needHelp);
            Console.WriteLine("Were there any positive experiences you would like to share? Please give specifics");
            string positiveExperience = Console.ReadLine();
            Console.WriteLine("Any other feedback to share? Please give specifics");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study?");
            string studyHours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyHours);
            Console.WriteLine("Thanks for your answers. Have a great day");
            Console.ReadLine();


        }
    }
}
