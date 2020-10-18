namespace Domain.Models
{
    public abstract class SharedData
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string Title { get; set; }
        public string About { get; set; }
        public string Description { get; set; }
    }
}