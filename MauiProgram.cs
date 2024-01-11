using ApplicationDevelopmentCW.Data;
using ApplicationDevelopmentCW.Services;
using Blazored.LocalStorage;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;


namespace ApplicationDevelopmentCW
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
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddMudServices();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
		
          
#endif

            builder.Services.AddSingleton<WeatherForecastService>();
            builder.Services.AddMudServices();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddSingleton<ITodoService, TodoService>();
            builder.Services.AddSingleton<IAddCoffeeService, AddCoffeeService>();
            return builder.Build();
        }
    }
}


