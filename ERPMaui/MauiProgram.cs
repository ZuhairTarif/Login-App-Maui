using Microsoft.Extensions.Logging;

namespace ERPMaui
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
                    fonts.AddFont("Inter.ttf", "InterRegular");
                    fonts.AddFont("Inter.ttf", "InterSemibold");
                });

    		builder.Logging.AddDebug();

            return builder.Build();
        }
    }
}
