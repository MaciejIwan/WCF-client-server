using Google.Apis.Books.v1;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAPIBooksExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var booksService = new BooksService(new BaseClientService.Initializer
            {
                ApiKey = "AIzaSyDCxRu6OdDMgLwgDGSTx-kUEhZZmSBzvvk"
            });

            var volumes = booksService.Volumes.List("harry potter").Execute().Items;
            var bookIds = volumes?.Select(volume => int.Parse(volume.Id));
            Console.WriteLine(volumes.Count);   
        }
    }
}
