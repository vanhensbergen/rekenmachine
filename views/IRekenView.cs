using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace rekenmachine.views
{
    public interface IRekenView
    {
        string GetGetal1Text();
        string GetGetal2Text();
        void AddClickHandler(RoutedEventHandler handler);
        string ActionParameter(Object sender);
        void SetDataSource(object source);
    }
}
