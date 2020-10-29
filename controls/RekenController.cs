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
        private readonly IContentLeverancier View;
        public RekenController(IContentLeverancier view)
        {
            Model = new Rekenaar();
            View = view;
            View.AddClickHandler(Button_Click);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool test1 = Model.IsGetal1(View.GetGetal1Text());
            bool test2 = Model.IsGetal2(View.GetGetal2Text());
            if (test1 && test2)
            {
                string bewerking = View.ActionParameter(sender);
                
                switch (bewerking)
                {
                    case "plus":
                        int Result = Model.TelOp();
                        View.SetResultText(Result);
                        break;
                    case "keer":
                        Result = Model.Vermenigvuldig();
                        View.SetResultText(Result);
                        break;

                }
                
               
            }
            
        }
    }
}
