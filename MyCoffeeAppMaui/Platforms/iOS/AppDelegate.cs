using Foundation;
using MyCoffeeApp.Helpers;
using UIKit;

namespace MyCoffeeAppMaui;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}

public class Environment : IEnvironment
{
    public void SetStatusBarColor(System.Drawing.Color color, bool darkStatusBarTint)
    {
        if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
        {
            var statusBar = new UIView(UIApplication.SharedApplication.KeyWindow.WindowScene.StatusBarManager.StatusBarFrame);
            statusBar.BackgroundColor = UIColor.FromRGB(color.R,color.B,color.G);
            UIApplication.SharedApplication.KeyWindow.AddSubview(statusBar);
        }
        else
        {
            var statusBar = UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) as UIView;
            if (statusBar.RespondsToSelector(new ObjCRuntime.Selector("setBackgroundColor:")))
            {
                statusBar.BackgroundColor = UIColor.FromRGB(color.R, color.B, color.G);
            }
        }
        var style = darkStatusBarTint ? UIStatusBarStyle.DarkContent : UIStatusBarStyle.LightContent;
        UIApplication.SharedApplication.SetStatusBarStyle(style, false);
        Platform.GetCurrentUIViewController()?.SetNeedsStatusBarAppearanceUpdate();
    }
}
