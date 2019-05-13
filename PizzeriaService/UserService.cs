using PizzeriaDomen.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Context = PizzeriaDomen.Entities.Context;

namespace PizzeriaService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]

    //[DataContractFormat]
    //[DataContract]
    //public class DataUser
    //{
    //    public DataUser() { }

    //    public DataUser(User user)
    //    {
    //        this.ID = user.ID;
    //        this.Name = user.Name;
    //        this.Login = user.Login;
    //        this.Password = user.Password;
    //        this.RoleID = user.RoleID;
    //    }
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public string Login { get; set; }
    //    public string Password { get; set; }
    //    public int RoleID { get; set; }
    //}



    //public class DataOrder
    //{
    //    public DataOrder() { }

    //    public DataOrder(Order order)
    //    {
    //        this.ID = order.ID;
    //        this.OrderComp = order.OrderComp;
    //        this.OrderStatus = order.OrderStatus;
    //    }
    //    public int ID { get; set; }
    //    public string OrderComp { get; set; }
    //    public DateTime OrderDate { get; set; }
    //    public string OrderStatus { get; set; }
    //}


    public class UserService : IUserContract
    {




        public void AddOrder(string OrderComp, DateTime OrderDate, string OrderStatus)
        {
            throw new NotImplementedException();
        }

        //public void AddUser(DataUser dataUser)
        //{
            //Context context = new Context();

            //User user = new User()
            //{
            //    Name = dataUser.Name,
            //    Login = dataUser.Login,
            //    Password = dataUser.Password,
            //    RoleID = 2
            //};

            //context.users.Add(user);
            //context.SaveChanges();
        //}

        //public DataUser GetUser(string login, string password)
        //{
        //    throw new NotImplementedException();

        //}

        //public List<DataUser> GetUsers()
        //{
        //    Context context = new Context();
        //    List<DataUser> dataUsers = new List<DataUser>();
        //    List<User> users = context.users.ToList();
        //    foreach (User user in users)
        //    {
        //        dataUsers.Add(new DataUser(user));
        //    }
        //    return dataUsers;
        //}

        public void Login(string Login, string Password)
        {
            throw new NotImplementedException();
        }

        public void Registrer(string Login, string Email, string Password, string RepeatPassword)
        {
            throw new NotImplementedException();
        }

        //public void UpdateUser(DataUser dataUser)
        //{
            
        //}
    }


}