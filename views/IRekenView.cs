using rekenmachine.controls;
using System;

namespace rekenmachine.views
{
    public interface IRekenView
    {
        string GetGetal1Text();
        string GetGetal2Text();
        string ActionParameter(Object sender);
        void SetDataSource(object source);
        void SetClickListener(IViewListener control);
    }
}
