using System;
using System.ComponentModel;

namespace rekenmachine.models
{
    public class Rekenaar:INotifyPropertyChanged
    {
        private double _Getal1;
        private double _Getal2;
        private double _Result;

        public double Result
        {
            get
            { 
                return _Result;
            }
            set 
            { 
                _Result = value; 
                OnPropertyChanged("Result"); 
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }


        public bool SetGetal1(string txt)
        {
            return double.TryParse(txt, out _Getal1);
        }

        internal void Bereken(string bewerking)
        {
            switch (bewerking)
            {
                case "+":
                    Result = _Getal1 + _Getal2;
                    break;
                case "-":
                    Result = _Getal1 / _Getal2;
                    break;
                case "x":
                    Result = _Getal1 * _Getal2;
                    break;
                case ":":
                    Result = _Getal1 / _Getal2;
                    break;
                default:
                    throw new NotImplementedException(bewerking);
            }
        }

        public bool SetGetal2(string txt)
        {
            return double.TryParse(txt, out _Getal2);
        }

        
        
    }
}
