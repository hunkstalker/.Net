using Dangl.Calculator;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CalculatorWithStyles.MAUI.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class CalcViewModel
    {
        public string Formula { get; set; }
        public string Result { get; set; } = "0";

        public ICommand OperationCommand => new Command(number => { Formula += number; });
        public ICommand ResetCommand => new Command(() =>
        {
            Result = "0";
            Formula = "";
        });
		public ICommand BackspaceCommand => new Command(number => {
            if (Formula.Length > 0)
            {
                Formula = Formula.Substring(0, Formula.Length - 1);
            }
        });
        public ICommand CalculateComand => new Command(() =>
        {
            if (Formula.Length == 0) return;
            var calculation = Calculator.Calculate(Formula.Replace('x', '*'));
            Result = calculation.Result.ToString();
        });
	}
}
