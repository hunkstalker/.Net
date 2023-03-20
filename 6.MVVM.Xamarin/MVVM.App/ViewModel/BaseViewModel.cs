using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace MVVM.App.ViewModel
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		public INavigation Navigation;

		public event PropertyChangedEventHandler PropertyChanged;

		public void OnpropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public async Task DisplayAlert(string title, string message, string cancel)
		{
			await Application.Current.MainPage.DisplayAlert(title, message, cancel);
		}

		public async Task<bool> DisplayAlert(string title, string message, string accept, string cancel)
		{
			return await Application.Current.MainPage.DisplayAlert(title, message, accept, cancel);
		}

		protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
		{
			if (EqualityComparer<T>.Default.Equals(field, value))
			{
				return false;
			}

			field = value;
			OnPropertyChanged(propertyName);

			return true;
		}

		protected void SetValue<T>(ref T backingFieled, T value, [CallerMemberName] string propertyName = null)
		{
			if (EqualityComparer<T>.Default.Equals(backingFieled, value))

			{
				return;
			}

			backingFieled = value;

			OnPropertyChanged(propertyName);
		}

		private string _title;
		public string Title
		{
			get { return _title; }
			set
			{
				SetProperty(ref _title, value);
			}
		}

		private ImageSource image;
		public ImageSource Image
		{
			get { return image; }
			set
			{
				image = value;
				OnpropertyChanged();
			}
		}

		private bool _isBusy;
		public bool IsBusy
		{
			get { return _isBusy; }
			set
			{
				SetProperty(ref _isBusy, value);
			}
		}
	}
}
