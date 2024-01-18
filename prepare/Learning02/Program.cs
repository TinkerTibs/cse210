using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        
        Job job1 = new Job();
        job1._company = "Thorin and Company";
        job1._jobTitle = "Burglar";
        job1._startYear = 2941;
        job1._endYear = 2942;

        Job job2 = new Job();
        job2._company = "Gandalf";
        job2._jobTitle = "Ring-bearer";
        job2._startYear = 3018;
        job2._endYear = 3019;

        Resume myResume = new Resume();
        myResume._name = "Aragorn Arathornson";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();


    }
}