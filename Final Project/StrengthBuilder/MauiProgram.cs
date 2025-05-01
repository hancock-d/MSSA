using Microsoft.Extensions.Logging;
using StrengthBuilder.Data;
using StrengthBuilder.Services;
using StrengthBuilder.View;
using StrengthBuilder.ViewModels;

namespace StrengthBuilder
{
    //Registers services and viewmodels for dependency injection
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

            //register services
            builder.Services.AddDbContext<AppDbContext>();
            builder.Services.AddSingleton<UserService>();

            builder.Services.AddSingleton<LoginViewModel>();
            builder.Services.AddSingleton<InputViewModel>();
            builder.Services.AddSingleton<WeekViewModel>();
            builder.Services.AddTransient<WorkoutViewModel>();

            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<InputPage>();
            builder.Services.AddSingleton<WeekPage>();
            builder.Services.AddTransient<WorkoutPage>();
#endif

            return builder.Build();
        }
    }
}
