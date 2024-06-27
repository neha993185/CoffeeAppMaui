using Microsoft.Extensions.Logging;
using MyCoffeeApp;
using CommunityToolkit.Maui;
using MyCoffeeApp.Helpers;
using MyCoffeeApp.Services;
using DotNet.Meteor.HotReload.Plugin;

namespace MyCoffeeAppMaui;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("CustomFont.ttf", "AC");
            fonts.AddFont("fa-regular-400.ttf", "FAR");
            fonts.AddFont("fa-solid-900.ttf", "FAS");
            fonts.AddFont("fa-brands-400.ttf", "FAB");

        }).UseMauiCommunityToolkit()
#if DEBUG
            .EnableHotReload();
#endif
#if IOS
DependencyService.Register<MyCoffeeAppMaui.Environment>();
#endif

#if ANDROID
        DependencyService.Register<MyCoffeeAppMaui.Environment>();
        DependencyService.Register<Toaster>();
#endif

#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
    }
}