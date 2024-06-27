using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.Core.View;
using MyCoffeeApp.Helpers;
using MyCoffeeApp.Services;

namespace MyCoffeeAppMaui;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {

        base.OnCreate(savedInstanceState);

    }

    public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
    {        base.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
    }
  
    }

    public class Toaster : IToast
{
    public void MakeToast(string message)
    {
        Toast.MakeText(Platform.AppContext, message, ToastLength.Long).Show();
    }
}

public class Environment : IEnvironment
{
    public async void SetStatusBarColor(System.Drawing.Color color, bool darkStatusBarTint)
    {
        if (Build.VERSION.SdkInt < Android.OS.BuildVersionCodes.Lollipop)
            return;

        var activity = Platform.CurrentActivity;
        var window = activity.Window;

        //this may not be necessary(but may be fore older than M)
        window.AddFlags(Android.Views.WindowManagerFlags.DrawsSystemBarBackgrounds);
        window.ClearFlags(Android.Views.WindowManagerFlags.TranslucentStatus);


        if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.M)
        {
            await Task.Delay(50);
            WindowCompat.GetInsetsController(window, window.DecorView).AppearanceLightStatusBars = darkStatusBarTint;
        }

        window.SetStatusBarColor(new Android.Graphics.Color(color.R,color.B,color.G));
    }
}

