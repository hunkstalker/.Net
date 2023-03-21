using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace BMICalculator.MAUI.MVVM.Models
{
	[AddINotifyPropertyChangedInterface]
    public class BMI
    {

		public float Height { get; set; }
        public float Weight{ get; set; }
		public float Result 
		{
			get 
			{
				return ((Weight / Height) / Height) * 10000;
			} 
		}

		private float result;

		public string ResultText
		{
			get
			{
				string template = "BMI: #";
				if(Result <= 15)
				{
					return template.Replace("#", "Moderate Thinness");
				}
				else if(Result > 15 && Result <= 23)
				{
					return template.Replace("#", "Mild Thinness");
				}
				else if(Result > 23 && Result <= 27)
				{
					return template.Replace("#", "Normal");
				}
				else if (Result > 27 && Result <= 35)
				{
					return template.Replace("#", "Overweight");
				}
				else
				{
					return template.Replace("#", "Obese Class I");
				}
			}
		}
	}
}
