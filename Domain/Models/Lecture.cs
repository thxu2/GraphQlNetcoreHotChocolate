using System.Collections.Generic;

namespace Domain.Models
{
    public class Lecture : SharedData
    {
        public List<Test> Tests { get; set; }
    }
}