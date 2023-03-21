using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMICalculator.MAUI.MVVM;

namespace BMICalculator.MAUI.MVVM.ViewModels
{
    public class BMIViewModel
    {
        public Models.BMI BMI { get; set; }

        public BMIViewModel()
        {
            BMI = new();
            BMI.Height = 175;
            BMI.Weight = 106;
        }
    }
}
