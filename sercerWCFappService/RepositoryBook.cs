﻿using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sercerWCFappService
{
    public interface IRepositoryBook
    {
        List<int> FindBooksByKeyPhrase(string phrase);
        Book GetBookById(int id);
    }

    public class RepositoryBook : IRepositoryBook
    {
        public List<int> FindBooksByKeyPhrase(string phrase)
        {
            return new List<int> { 0,1 };
        }

        public Book GetBookById(int id)
        {
            return new Book();
        }
    }
}