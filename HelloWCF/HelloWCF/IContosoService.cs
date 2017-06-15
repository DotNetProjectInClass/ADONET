using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HelloWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IContosoService
    {
        [OperationContract]
        int Add(int a, int b);

        [OperationContract]
        int Substract(int a, int b);

        [OperationContract]
        Student GetStudentById(int id);

        // TODO: Add your service operations here
    }
}
