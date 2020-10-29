using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using rekenmachine.controls;
using rekenmachine.views;

namespace rekenmachine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IContentLeverancier
    {

        public RekenController Controller;
       
        public MainWindow()
        {
            InitializeComponent();
            Controller = new RekenController(this);
        }
        public void AddClickHandler(RoutedEventHandler handler)
        {
            TelOpKnop.Click += handler;
        }

        public string GetGetal1Text()
        {
            return Getal1.Text;
        }
        public string GetGetal2Text()
        {
            return Getal2.Text;
        }

        public void SetResultText(int value)
        {
            Result.Text = value.ToString();
        }

        private void Button_Click_To_Add(object sender, RoutedEventArgs e)
        {
            bool test1 = int.TryParse(Getal1.Text, result: out int getal1);
            bool test2 = int.TryParse(Getal2.Text, result: out int getal2);
            if (test1 && test2)
            {
                int result = getal1 + getal2;
                Result.Text =  result.ToString();
            }
            else
            {

            }
        }
        
    }
}
