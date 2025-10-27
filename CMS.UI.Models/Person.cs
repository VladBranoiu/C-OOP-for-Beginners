namespace CMS.UI.Models
{
    public  class Person
    {
        public Person()
        {
            Console.WriteLine("Calling Person.Person()");
        }

        public Person(string firstName, string lastName)
        {
            Console.WriteLine("Calling Person.Person(string, string)");

            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName{ get; set; } 
        public string LastName { get; set; } 

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
