using System;

namespace _07_ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projectsCount = int.Parse(Console.ReadLine());

            int timeToMakeOneProject = 3;
            Console.WriteLine($"The architect {name} will need {projectsCount * timeToMakeOneProject} hours to complete {projectsCount} project/s.");
        }
    }
}
