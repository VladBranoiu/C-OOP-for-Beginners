using System.Security.Cryptography.X509Certificates;

namespace CMS.UI.Models;

public class Student : Person
{
    public List<string> Hobbies { get; set; }

    public int StudentId = 10000;

    // public const int MaxEnrolledCourses = 3;  can't be modified and called in program.cs

    //readonly field
    public readonly int MaxEnrolledCourses = 3; //can be modified just in constructor

    //static field
    public static int MaxBooksAllowed = 6;

    //Student constructor
    public Student()
    {
        Console.WriteLine("Calling Student.Student() ");
        // All initializations goes here
        int TotalCourses = 6;
        MaxEnrolledCourses = TotalCourses;
    }

    public Student(int id, string firstName, string lastName) : base(firstName, lastName)
    { 
        Console.WriteLine("Calling Student.Student(int, string, string) ");
        StudentId = id;
        FirstName = firstName;
        LastName = lastName;

    }

    //Destructor
    //void ~Student()
    //{ 
    //    //Cleanup code goes here.
    //}

    public int GetId()
    {
        return StudentId;
    }
}
