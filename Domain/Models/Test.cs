namespace Domain.Models
{
    public class Test : SharedData
    {
        public TestType Type { get; set; }
        public Volume Volume { get; set; }
    }

    public enum TestType
    {
        Quiz,
        Task
    }
}