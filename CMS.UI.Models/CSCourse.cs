
namespace CMS.UI.Models
{
    public class CSCourse : ICourse
    {
        public List<CourseSubject> Subjects => throw new NotImplementedException();

        public int TotalDurationInDays { get => throw new NotImplementedException();
                                         set => throw new NotImplementedException(); }

        public void AddSubject(CourseSubject subject)
        {
            throw new NotImplementedException();
        }

        public void AddSubject(List<CourseSubject> subjectCollection)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubject(CourseSubject subject)
        {
            throw new NotImplementedException();
        }
    }
}
