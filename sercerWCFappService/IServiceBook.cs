using Dto;
using dtos;
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
        [FaultContract(typeof(FaultException))]
        List<String> GetAllBooksIdsByPhrase(string phrase);

        [OperationContract]
        [FaultContract(typeof(FaultException))]
        Book GetBookById(String id);

    }
}
