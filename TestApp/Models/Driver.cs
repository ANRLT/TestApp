namespace TestApp.Models
{
    public class Driver
    {
        internal string firstName { get; set; }
        internal string lastName { get; set; }
        internal int personalNumber { get; set; }
        internal Guid id { get; set; }

        public Driver(string firstName, string lastName, int personalNumber, Guid id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.personalNumber = personalNumber;
            this.id = id;
        }
    }
}