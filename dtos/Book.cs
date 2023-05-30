using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public struct Book
    {
        public String Id { get; set; }
        public String Title { get; set; }
        public IList<String> Authors { get; set; }

        public override String ToString()
        {
            string authorsString = "";
            foreach (var author in Authors)
            {
                authorsString += (author + "\n");
            }
            return $"Title: {Title},\nAuthors:\n{authorsString}";
        }

    }
}
