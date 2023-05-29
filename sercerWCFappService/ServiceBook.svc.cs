﻿using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceBook" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceBook.svc or ServiceBook.svc.cs at the Solution Explorer and start debugging.
    public class ServiceBook : IServiceBook
    {
        IRepositoryBook repositoryBook = new RepositoryBook();

        public List<int> GetAllBooksIdsByPhrase(string phrase)
        {
            return repositoryBook.FindBooksByKeyPhrase(phrase);
        }

        public Book GetBookById(int id)
        {
            return repositoryBook.GetBookById(id);
        }

        public string HelloWorld()
        {
            return "Hello World";
        }

        public string Hi(string fullname)
        {
            return "Hi " + fullname;
        }

        public int sum(int a, int b)
        {
            return a + b;
        }
    }
}
