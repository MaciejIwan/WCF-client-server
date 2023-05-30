using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace server
{
    [ServiceContract]
    public interface IServiceBook
    {
        [OperationContract]
        string HelloWorld();

        [OperationContract]
        List<String> GetAllBooksIdsByPhrase(string phrase);

        [OperationContract]
        [FaultContract(typeof(NullReferenceException))]
        Book GetBookById(String id);

    }
}
