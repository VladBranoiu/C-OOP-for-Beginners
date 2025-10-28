namespace CMS.UI.Models
{
    public abstract class Hobby
    {
        private string name;

        public string GetHobbyName()
        {
            return name;
        }

        public abstract string GetTypeOfHobby();
    }

    public class PhotographyHobby : Hobby
    {
        public override string GetTypeOfHobby()
        {
            throw new NotImplementedException();
        }
    }
}
