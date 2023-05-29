using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
        public struct Book
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public List<Author> Authors { get; set; }

            public override string ToString()
            {
                string authorsString = "";
                Authors.ForEach(author => authorsString += (author.ToString() + "\n"));
                return $"Title: {Title},\nAuthors:\n{authorsString}";
            }

        }
}
