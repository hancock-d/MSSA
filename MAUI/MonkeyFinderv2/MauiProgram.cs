using Microsoft.Extensions.Logging;
using MonkeyFinderv2.Services;
using MonkeyFinderv2.View;
using MonkeyFinderv2.ViewModel;

namespace MonkeyFinderv2
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
            // register services
            builder.Services.AddSingleton<IConnectivity>(Connectivity.Current); //add
            builder.Services.AddSingleton<IGeolocation>(Geolocation.Default); //add
            builder.Services.AddSingleton<IMap>(Map.Default); //add
            builder.Services.AddSingleton<MainPage>(); //add
            builder.Services.AddSingleton<MonkeyService>(); //add
            builder.Services.AddSingleton<MonkeysViewModel>(); //add
            builder.Services.AddTransient<MonkeyDetailsViewModel>(); //add
            builder.Services.AddTransient<DetailsPage>();
#endif

            return builder.Build();
        }
    }
}
