using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Android.Views;
using System.Drawing;

namespace MVVM.App.Droid
{
    [Activity(Label = "MVVM.App", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
			base.OnCreate(savedInstanceState);
			Xamarin.Forms.Forms.Init(this, savedInstanceState);

			LoadApplication(new App());
			TransparentStatusBar();
		}
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
		private void TransparentStatusBar()
		{
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Kitkat)
			{
				// Pantalla completa? No noto cambios ni idea de qué hace
				//Window.SetFlags(WindowManagerFlags.LayoutNoLimits, WindowManagerFlags.LayoutNoLimits);

				// Translúcido
				//Window.AddFlags(WindowManagerFlags.TranslucentStatus);

				// Clear FLAG_TRANSLUCENT_STATUS flag:
				//Window.ClearFlags(WindowManagerFlags.TranslucentStatus);
				// Transparente
				//Window.SetStatusBarColor(Android.Graphics.Color.Transparent);
			}
		}
	}
}