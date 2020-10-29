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

        public string ActionParameter(object sender)
        {
            Button knop = sender as Button;
            return (string)knop.Tag;
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
        
    }
}
