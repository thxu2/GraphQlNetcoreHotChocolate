using System.Collections;
using System.Runtime.CompilerServices;

namespace Infrastructure
{
    public interface IRepository<out T>
    {
       T GetData();
       void Configure(string options);
    }
}