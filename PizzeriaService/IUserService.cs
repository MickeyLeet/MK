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

        [OperationContract]
        void AddOrder(string OrderComp, DateTime OrderDate, string OrderStatus);


        //[OperationContract]
        //DataUser GetUser(string login, string password);


        //[OperationContract]
        //void AddUser(DataUser dataUser);

        //[OperationContract]
        //void UpdateUser(DataUser dataUser);

        //[OperationContract]
        //List<DataUser> GetUsers();



    }
}
