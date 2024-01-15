using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "General Manager";
        job1._company = "Kneaders";
        job1._startYear = 2021;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Member Service Representitive";
        job2._company = "Deseret First Credit Union";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Jospeh Anderson";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}