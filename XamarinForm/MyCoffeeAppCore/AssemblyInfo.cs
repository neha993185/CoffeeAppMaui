using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

[assembly: ExportFont("CustomFont.ttf", Alias = "AC")]
[assembly: ExportFont("fa-regular-400.ttf", Alias = "FAR")]
[assembly: ExportFont("fa-solid-900.ttf", Alias = "FAS")]
[assembly: ExportFont("fa-brands-400.ttf", Alias = "FAB")]