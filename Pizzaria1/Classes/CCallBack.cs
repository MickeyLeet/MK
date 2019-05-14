using PizzeriaService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pizzaria1.Classes
{
    public class CCallBack : ICallBack
    {
        void ICallBack.Error(string message)
        {
            MessageBox.Show(message, "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
