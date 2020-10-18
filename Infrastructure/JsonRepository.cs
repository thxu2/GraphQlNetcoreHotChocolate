using System.IO;
using Newtonsoft.Json;

namespace Infrastructure
{
    public class JsonRepository<T> : IRepository<T>
    {
        private string _path;

        public T GetData()
        {
            var data = JsonConvert.DeserializeObject<T>(File.ReadAllText(_path));
            return data;
        }

        public void Configure(string options)
        {
            _path = options;
        }
    }
}