using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace sercerWCFappService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceBook" in both code and config file together.
    [ServiceContract]
    public interface IServiceBook
    {
        [OperationContract]
        string HelloWorld();

        [OperationContract]
        string Hi(String fullname);

        [OperationContract]
        int sum(int a, int b);
    }
}
