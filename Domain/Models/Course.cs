using System.Collections.Generic;

namespace Domain.Models
{
    public class Course : SharedData
    {
        public List<Section> Sections { get; set; }
        public List<Test> Tests { get; set; }
    }
}