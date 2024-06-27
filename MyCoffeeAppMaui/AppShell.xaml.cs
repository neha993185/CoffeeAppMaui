using MyCoffeeApp.Views;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace MyCoffeeApp
{
    public partial class AppShell : Microsoft.Maui.Controls.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(AddMyCoffeePage),
                typeof(AddMyCoffeePage));

            Routing.RegisterRoute(nameof(MyCoffeeDetailsPage),
                typeof(MyCoffeeDetailsPage));

            Routing.RegisterRoute(nameof(RegistrationPage),
                typeof(RegistrationPage));
        }
    }
}
