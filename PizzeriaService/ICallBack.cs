using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaService
{
    public interface ICallBack
    {
        [OperationContract(IsOneWay = true)]
        void Error(string message);

        
    }
}
