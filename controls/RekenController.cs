using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using rekenmachine.models;
using rekenmachine.views;

namespace rekenmachine.controls
{
    public class RekenController
    {
        private readonly Rekenaar Model;
        private readonly IRekenView View;
        public RekenController(IRekenView view, Rekenaar Model)
        {
            this.Model = Model;
            View = view;
            View.AddClickHandler(Button_Click);

        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool test1 = Model.SetGetal1(View.GetGetal1Text());
            bool test2 = Model.SetGetal2(View.GetGetal2Text());
            if (test1 && test2)
            {
                string bewerking = View.ActionParameter(sender);
                Model.Bereken(bewerking);
                
               
            }
            
        }
    }
}
