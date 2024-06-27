# MyCoffeeApp

Sample for migrating xamarin form app to maui using .NET Upgrade Assistant (Side-by-side)
Xamarin form App code is present inside XamarinForm Folder.

.NET Upgrade Assistant: The .NET Upgrade Assistant helps you upgrade Xamarin.Forms projects to .NET Multi-platform App UI (.NET MAUI) by converting the solution’s project file and by performing common code updates. Specifically, the tool will:
Convert the Xamarin.Forms class library project, Xamarin.iOS project and Xamarin.Android project to SDK-style projects.
Update the target framework in project files to net7.0-android and net7.0-ios, as required.
Set true in project files.
Add additional project properties and remove project properties that aren’t required.
Add and remove specific NuGet packages:
Remove the Xamarin.Forms and Xamarin.Essentials NuGet packages.
Replace the Xamarin.CommunityToolkit NuGet package with the .NET MAUI Community Toolkit NuGet package.
Replace Xamarin.Forms compatible versions of the SkiaSharp NuGet packages with .NET MAUI compatible versions, if used.
Remove references to the Xamarin.Essentials namespace, and replace the Xamarin.Forms namespace with the Microsoft.Maui and Microsoft.Maui.Controls namespaces.
