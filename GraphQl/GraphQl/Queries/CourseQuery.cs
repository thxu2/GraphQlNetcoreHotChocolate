using System.Collections.Generic;
using System.IO;
using System.Linq;
using Domain.Models;
using Infrastructure;
using Microsoft.AspNetCore.Hosting;
using WebApplication1.Application;

namespace WebApplication1.Queries
{
    public class CourseQuery
    {
        private readonly IRepository<CourseData> _repository;
        
        public CourseQuery(IRepository<CourseData> repository, IWebHostEnvironment environment)
        {
            _repository = repository;
            _repository.Configure(Path.Combine(environment.ContentRootPath, "sample-catalog.json"));
        
        }
        
        public IEnumerable<Course> GetCourses()
        {
            var data = _repository.GetData().Courses;
            return  data;
        }
        public IEnumerable<Course> GetCourse(int id)
        {
            var data = _repository.GetData().Courses.Where(c=>c.Id== id);
            return  data;
        }
    }
}