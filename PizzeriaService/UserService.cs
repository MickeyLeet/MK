using PizzeriaDomen.Entities;
using PizzeriaDomen.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;



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


    public class UserService : IUserService
    {
        ICallBack callBack
        {
            get => OperationContext.Current.GetCallbackChannel<ICallBack>();
        }

        EFContext context = new EFContext();



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


        void IUserService.Registrer(string Login, string Email, string Password, string RepeatPassword)
        {
            if (Login.Length < 1)
            {
                callBack.Error("Введіть логін");
                return;
            }

            if (Email.Length < 1)
            {
                callBack.Error("Введіть пошту");
                return;
            }

            if (context.Users.FirstOrDefault((x) => x.Email == Email) != null)
            {
                callBack.Error("Користувач з такою поштою вже зареєстрований");
                return;
            }

            if (RepeatPassword != Password)
            {
                callBack.Error("Паролі не збігаються");
                return;
            }

            string hashPassword = CHash.CreateMD5(Password);

            context.Users.Add(new PizzeriaDomen.Entities.User { Login = Login, Password = hashPassword, Email = Email });
            context.SaveChanges();

            //public void UpdateUser(DataUser dataUser)
            //{

            //}
        }
        void IUserService.Login(string Login, string Password)
        {
            if (Login.Length < 1)
            {
                callBack.Error("Введіть логін");
                return;
            }

            if (Password.Length < 1)
            {
                callBack.Error("Введіть пароль");
                return;
            }

            string hashPassword = CHash.CreateMD5(Password);


            User user = context.Users.FirstOrDefault((x) => x.Login == Login && x.Password == hashPassword);
            if (user != null) 
            {
                
            }
            else
            {
                callBack.Error("Не правильно введений логін чи пароль");
            }
        }

    }


}