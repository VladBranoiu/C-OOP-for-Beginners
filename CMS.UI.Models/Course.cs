using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;

namespace CMS.UI.Models;

public class Course : ICourse
{
    public int CourseId;
    public string CourseName;
    public static int MaxSubjects = 8;

    private List<CourseSubject> subjects = new List<CourseSubject>();

    public List<CourseSubject> Subjects
    {
        get { return subjects; }
        private set { subjects = value; }
    }

    public int TotalDurationInDays { get => throw new NotImplementedException(); 
        set => throw new NotImplementedException(); }

    public void AddSubject(CourseSubject subject)
    {
        subjects.Add(subject);
    }

    public void AddSubject(List<CourseSubject> subjectCollection)
    {
        subjects.AddRange(subjectCollection);
    }

    public void RemoveSubject(CourseSubject subject)
    {
        subjects.Remove(subject);
    }


}
