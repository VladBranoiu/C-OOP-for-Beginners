using CMS.UI.Models;
using CMS.UI.Display;
using System.Reflection.Metadata.Ecma335;

//Object Instantiation
Student student =  new Student();
Staff staff = new Staff();


Course computerScience = new Course(); //if we had constructor , we could have assigned the value in ()
computerScience.CourseId = 201;
computerScience.CourseName = "ComputerScience";
Console.WriteLine(computerScience.CourseId);
Console.WriteLine(computerScience.CourseName);


// Field assignment
student.FirstName = "John";
Console.WriteLine(student.FirstName);

Student student2 = new Student()
{
    FirstName = "John",
    LastName = "McCarter",
    StudentId = 10001
};

//readonly variable
//student2.MaxEnrolledCourses = 6;

//Static variables
Student.MaxBooksAllowed = 8;
Console.WriteLine(Student.MaxBooksAllowed);

//Value and reference types
Console.WriteLine("Value and reference types");
int a = 10;
Console.WriteLine(a);
int b = a;
b = 20;
Console.WriteLine(a);

student.FirstName = "John";
Console.WriteLine(student.FirstName);
student2 = student;
student2.FirstName = "Ionut";
Console.WriteLine(student.FirstName);

//Acces Modifiers
staff.FirstName = "Staff1";

//Methods
Student student3 = new Student()
{
    FirstName = "John",
    LastName = "McCarter",
    StudentId = 10003
};

Console.WriteLine(student3.GetId());
Console.WriteLine(student3.GetFullName());

//Constructor and Desctructor
Student student4 = new Student();
Student student5 = new Student(10004, "Ion", "Gheorghe");

//Properties
Staff staff3 = new Staff();
string name = staff3.FirstName;
name = staff3.LastName;
int iD = staff3.Id;
//staff3.Id = 10; // can't set because private set

//Types of passing parameters
decimal electiveFees = 5000;
decimal roughFees = 5000;
decimal finalFees = 5000;
Console.WriteLine(electiveFees);
Console.WriteLine(roughFees);
Console.WriteLine(finalFees);

staff3.CalculateFees(electiveFees, ref roughFees, out finalFees);

Console.WriteLine("After calculating fees");
Console.WriteLine(electiveFees);
Console.WriteLine(roughFees);
Console.WriteLine(finalFees);

//Method Overloading
staff3.UpdateInfo("John");
staff3.UpdateInfo("John", "Smith");

//Static class
Display.Show("Hello");

//Interfaces
ICourse csCourse = new CSCourse();
ICourse eleCourse = new ElectronicsCourse();

Console.WriteLine(csCourse.GetTotalElectives());

ICourse.DefaultElectives = 10;

Student student1 = new Student();
student1.GetFullName();

List<string> hobbies = student1.Hobbies;

//Inheritance
Student student6 = new Student(10001, "Robert", "Smith");
Console.WriteLine(student6.GetFullName());

//Castig in inhertitance
Person person = new Student(10001, "David", "Smith");
Console.WriteLine(person.GetFullName);

//List<string> fullname = person.Hobbies;
//List<string> fullname = (person as Student).Hobbies; //as casting

Student student7 = person as Student;
if (student7 != null)
{ 
    List<string> lstHobbies = student7.Hobbies;
}

if (person is Student)
{ 
    //Refer Student members here
    Student student8 = person as Student;
    List<string> lstHobbies2 = student8.Hobbies;
}

//Polymorphism
