# Softwium.cs
Web-API for [softwium.com](https://softwium.com) free public API that enables developers to effortlessly obtain fake JSON data.

## Example
```cs
using SoftwiumApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new Softwium();
            string books = await api.GetBooks();
            Console.WriteLine(books);
        }
    }
}
```
