using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace dtos
{
    [DataContract]
    public class BookNotFoundException : FaultException
    {
        [DataMember]
        public string Message { get; set; }

        public BookNotFoundException(string message)
        {
            Message = message;
        }
    }
}
