using Android.App;
using Android.OS;
using Android.Views;

using Xamarin.Forms;
using Plugin.CurrentActivity;
using StatusBar.App.Droid.StatusBar;
using StatusBar.App.ViewModels;

[assembly:Dependency(typeof(ClStatusBar))]
namespace StatusBar.App.Droid.StatusBar
{
	internal class ClStatusBar : VMStatusBar
	{
		WindowManagerFlags _originalFlags;
		Window GetCurrentWindow()
		{
			var window = CrossCurrentActivity.Current.Activity.Window;
			window.ClearFlags(WindowManagerFlags.TranslucentStatus);
			window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
			return window;
		}
		public void CambiarColor()
		{
			if(Build.VERSION.SdkInt >= BuildVersionCodes.M)
			{
				Device.BeginInvokeOnMainThread(() =>
				{
					var currentWindow = GetCurrentWindow();
					currentWindow.DecorView.SystemUiVisibility = (StatusBarVisibility)SystemUiFlags.LayoutStable;
					currentWindow.SetStatusBarColor(Android.Graphics.Color.Blue);
				});
			}
		}

		public void MostrarStatusBar()
		{
			var activity = (Activity)Forms.Context;
			var attrs = activity.Window.Attributes;
			attrs.Flags = _originalFlags;
			activity.Window.Attributes = attrs;
		}

		public void OcultarStatusBar()
		{
			var activity = (Activity)Forms.Context;
			var attrs = activity.Window.Attributes;
			_originalFlags = attrs.Flags;
			attrs.Flags = WindowManagerFlags.Fullscreen;
			activity.Window.Attributes = attrs;
		}

		public void Translucido()
		{
			var activity = (Activity)Forms.Context;
			var attrs = activity.Window.Attributes;
			_originalFlags = attrs.Flags;
			attrs.Flags = WindowManagerFlags.TranslucentStatus;
			activity.Window.Attributes = attrs;
		}

		public void Transparente()
		{
			if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
			{
				Device.BeginInvokeOnMainThread(() =>
				{
					var currentWindow = GetCurrentWindow();
					currentWindow.DecorView.SystemUiVisibility = (StatusBarVisibility)SystemUiFlags.LayoutFullscreen;
					currentWindow.SetStatusBarColor(Android.Graphics.Color.Transparent);
				});
			}
		}
	}
}