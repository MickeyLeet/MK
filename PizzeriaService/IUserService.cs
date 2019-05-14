using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaService
{
    //[DataContract]
    //public class DataAccount
    //{
    //    [DataMember]
    //    public bool IsAdmin { get; set; }
    //}
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        void Registrer(string Login, string Email, string Password, string RepeatPassword);
        [OperationContract]
        bool Login(string Login, string Password);

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
