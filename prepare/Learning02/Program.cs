using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        job1._jobTitle = "Software Engineer";
        job2._jobTitle = "Manager";
        job1._company = "Microsoft";
        job2._company = "Apple";
        job1._startYear = 2019;
        job1._endYear = 2022;
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume person1 = new Resume();
        person1._jobs = new List<Job>
        {
            job1, job2
        } ;
        person1._name = "Allison";
        person1.Display();
        

    }
}