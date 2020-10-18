using System.Collections.Generic;

namespace Domain.Models
{
    public class Section : SharedData
    {
        public List<Lecture> Lectures { get; set; }
        public List<Test> Tests { get; set; }
    }
}