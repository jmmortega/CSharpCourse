using CSharpCourse.MVVM.Model;
using CSharpCourse.MVVM.Services;
using CSharpCourse.MVVM.Services.Interfaces;
using CSharpCourse.MVVM.ViewModel.Base;
using CSharpCourse.MVVM.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CSharpCourse.MVVM.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; RaisePropertyChanged("Value"); }
        }

        private List<Drink> _drinks;
        public List<Drink> Drinks
        {
            get
            {
                return _drinks;
            }
            set
            {
                _drinks = value; RaisePropertyChanged("Drinks");
            }
        }


        private IDrinkService _drinkService;

        public MainWindowViewModel()
        {
            Name = "Hello";
            _drinkService = new DrinkService();
        }

        public ICommand CommandChangeName
        {
            get
            {
                return new RelayCommand(() =>
                {
                    Name = "Hello MVVM";
                });
            }
        }

        public ICommand CommandRefreshDrinks
        {
            get
            {
                return new RelayCommand(() =>
                {
                    _drinks = _drinkService.CreateDrinks();
                });
            }
        }

    }
}
