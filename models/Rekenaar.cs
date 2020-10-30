using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekenmachine.models
{
    public class Rekenaar:INotifyPropertyChanged
    {
        private int _Getal1;
        private int _Getal2;
        private int _Result;

        public int Result
        {
            get => _Result;
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

        private void TelOp()
        {
            Result = _Getal1 + _Getal2;
        }

        public bool SetGetal1(string txt)
        {
            return int.TryParse(txt, out _Getal1);
        }

        internal void Bereken(string bewerking)
        {
            switch (bewerking)
            {
                case "+":
                    TelOp();
                    break;
                case "-":
                    TrekAf();
                    break;
                case "x":
                    Vermenigvuldig();
                    break;
                case ":":
                    Deel();
                    break;
                default:
                    throw new NotImplementedException(bewerking);
            }
        }

        private void Deel()
        {
            throw new NotImplementedException();
        }

        public bool SetGetal2(string txt)
        {
            return int.TryParse(txt, out _Getal2);
        }

        private void TrekAf()
        {
            Result = _Getal1 - _Getal2;
        }
        private void Vermenigvuldig()
        {
            Result = _Getal1 * _Getal2;
        }
    }
}
