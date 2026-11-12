using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Habit_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habit_Tracker.ViewModels
{
    public partial class CalendarViewModel : ObservableObject
    {
        private readonly IPopupService _popupService;

        public CalendarViewModel(IPopupService popupService)
        {
            _popupService = popupService;
        }

        [RelayCommand]
        private async Task DaySelectedAsync(Day selectedDay)
        {
            if (selectedDay is null) return;
        }
    }
}
