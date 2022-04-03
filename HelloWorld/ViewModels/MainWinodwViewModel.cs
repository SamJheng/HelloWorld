using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ViewModels
{
    public class MainWinodwViewModel: ViewModelBase
    {
        private double _boundNumber = 100;
        public double BoundNumber
        {
            get { return _boundNumber; }
            set
            {
                if (_boundNumber != value)
                {
                    _boundNumber = value;
                    OnPropertyChanged(nameof(BoundNumber));
                }
            }
        }
    }
}
