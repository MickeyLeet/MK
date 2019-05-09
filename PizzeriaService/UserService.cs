using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class UserService:IUserService
    {
    }
}
