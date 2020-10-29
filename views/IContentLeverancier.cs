using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace rekenmachine.views
{
    public interface IContentLeverancier
    {
        string GetGetal1Text();
        string GetGetal2Text();
        void SetResultText( int value);
        void AddClickHandler(RoutedEventHandler handler);

        string ActionParameter(Object sender);
    }
}
