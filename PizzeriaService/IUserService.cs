using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaService
{
    [ServiceContract]
    public interface IUserContract
    {
        [OperationContract(IsOneWay = true)]
        void Registrer(string Login, string Email, string Password, string RepeatPassword);
        [OperationContract(IsOneWay = true)]
        void Login(string Login, string Password);
    }
}
