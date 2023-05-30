using Dto;
using Google.Apis.Books.v1;
using Google.Apis.Services;
using Google.Apis.Books.v1.Data;
using System.Collections.Generic;
using System.Linq;

using System;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceBook" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceBook.svc or ServiceBook.svc.cs at the Solution Explorer and start debugging.
    public class ServiceBook : IServiceBook
    {
        private BooksService booksService;

        public ServiceBook()
        {
            string credentialsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "credentials.txt");
            string apiKey = File.ReadAllText(credentialsPath);

            booksService = new BooksService(new BaseClientService.Initializer
            {
                ApiKey = apiKey
            }) ;
        }


        public List<String> GetAllBooksIdsByPhrase(string phrase)
        { 
            var volumes = booksService.Volumes.List(phrase).Execute().Items;
            var ids = volumes?.Select(volume => volume.Id).ToList();
            return ids;
        }

        public Book GetBookById(String id)
        {
            var volume = booksService.Volumes.Get(id.ToString()).Execute();

            var book = new Book
            {
                Id = volume.Id,
                Title = volume.VolumeInfo.Title,
                Authors = volume.VolumeInfo.Authors
            };

            return book;
        }

        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
