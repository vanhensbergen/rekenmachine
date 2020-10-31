using System.Windows;
using System.Windows.Controls;
using rekenmachine.controls;
using rekenmachine.models;
using rekenmachine.views;

namespace rekenmachine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IRekenView
    {
        public MainWindow()
        {
            InitializeComponent();
            Rekenaar Model = new Rekenaar();
            _ = new RekenController(this, Model);
            SetDataSource(Model);
        }

        public string ActionParameter(object sender)
        {
            Button knop = sender as Button;
            return (string)knop.Tag;
        }

        public void AddClickHandler(RoutedEventHandler handler)
        {
            TelOpKnop.Click += handler;
            TrekAfKnop.Click += handler;
            KeerKnop.Click += handler;
            DeelKnop.Click += handler;

        }

        public string GetGetal1Text()
        {
            return Getal1.Text;
        }
        public string GetGetal2Text()
        {
            return Getal2.Text;
        }

        public void SetDataSource(object source)
        {
            DataContext = source;
        }
    }
}
