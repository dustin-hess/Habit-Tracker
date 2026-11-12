using Habit_Tracker.Views;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Habit_Tracker.ViewModels;

namespace Habit_Tracker
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<CalendarViewModel>();
            builder.Services.AddSingleton<CalendarPage>();

            //builder.Services.AddTransientPopup<DayHabitPopup, DayHabitPopupViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
