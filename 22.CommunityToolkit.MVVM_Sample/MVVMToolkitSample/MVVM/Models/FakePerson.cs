
using CommunityToolkit.Mvvm.ComponentModel;

namespace MVVMToolkitSample.MVVM.Models
{
     public partial class FakePerson : ObservableObject
     {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
		private string _firstName;
		[ObservableProperty]
		private string _lastName;

		partial void OnFirstNameChanged(string value)
		{
			Console.WriteLine(value);
		}

		public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
     }
}