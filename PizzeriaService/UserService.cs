﻿using PizzeriaDomen.Entities;
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


        public void Registrer(string Login, string Email, string Password, string RepeatPassword)
        {
            if (string.IsNullOrEmpty(Login))
            {
                throw new Exception("Введіть логін");
                //callBack.Error();
                //return;
            }

            if (string.IsNullOrEmpty(Email))
            {
                throw new Exception("Введіть пошту");
            }

            if (context.Users.FirstOrDefault((x) => x.Email == Email) != null)
            {
                throw new Exception("Користувач з такою поштою вже зареєстрований");
            }

            if (RepeatPassword != Password)
            {
                throw new Exception("Паролі не збігаються");
            }

            //string hashPassword = CHash.CreateMD5(Password);
            int roleId = context.Roles.FirstOrDefault(t => t.Name == "User").ID;


            context.Users.Add(new PizzeriaDomen.Entities.User { Login = Login, Password = Password, Email = Email, RoleID = roleId });
            context.SaveChanges();

            //public void UpdateUser(DataUser dataUser)
            //{

            //}
        }
        public bool Login(string Login, string Password)
        {
            if (string.IsNullOrEmpty(Login))
            {
                throw new Exception("Введіть логін");
            }

            if (string.IsNullOrEmpty(Password))
            {
                throw new Exception("Введіть пароль");
            }



            User user = context.Users.FirstOrDefault(x => x.Login == Login && x.Password == Password);
            if (user != null)
            {
                if (user.RoleID == context.Roles.FirstOrDefault(t => t.Name == "Admin").ID)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new Exception("Не правильно введений логін чи пароль");
            }
        }

        
        //public void ReturnProducts(string Name, float Price, string Description)
        //{
        //context.Products.FirstOrDefault(x => x.Name == Name && x.Description == Description && x.Price == Price);

        //}
    }


}