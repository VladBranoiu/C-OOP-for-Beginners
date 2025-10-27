
namespace CMS.UI.Models
{
    public class ElectronicsCourse : ICourse
    {

        List<CourseSubject> ICourse.Subjects => throw new NotImplementedException();

        int ICourse.TotalDurationInDays { get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); }

        void ICourse.AddSubject(CourseSubject subject)
        {
            throw new NotImplementedException();
        }

        void ICourse.AddSubject(List<CourseSubject> subjectCollection)
        {
            throw new NotImplementedException();
        }

        void ICourse.RemoveSubject(CourseSubject subject)
        {
            throw new NotImplementedException();
        }
    }
}
