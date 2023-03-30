namespace TestApp.Models
{
    public class Car
    {
        public string mark { get; set; }
        public int driverNumber { get; set; }
        public Guid Id { get; set; }

        public Car (string mark, int driverNumber, Guid id)
        {
            this.mark = mark;
            this.driverNumber = driverNumber;
            Id = id;
        }
    }
}
