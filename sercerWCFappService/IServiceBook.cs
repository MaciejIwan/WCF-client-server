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
        string Hi(String fullname);

        [OperationContract]
        int sum(int a, int b);

        [OperationContract]
        List<int> GetAllBooksIdsByPhrase(string phrase);

        [OperationContract]
        [FaultContract(typeof(NullReferenceException))]
        Book GetBookById(int id);

        }
    }
