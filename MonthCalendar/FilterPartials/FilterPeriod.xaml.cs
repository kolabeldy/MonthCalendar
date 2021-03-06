using System.Windows;
using System;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace MonthCalendar.FilterPartials
{
    public partial class FilterPeriod : UserControl
    {
        public FilterPeriod()
        {
            InitializeComponent();
        }
        private void StartPeriodPicker_Opened(object sender, RoutedEventArgs e)
        {
            DatePicker datepicker = (DatePicker)sender;
            Popup popup = (Popup)datepicker.Template.FindName("PART_Popup", datepicker);
            Calendar cal = (Calendar)popup.Child;
            cal.DisplayModeChanged += CalenderStart_DisplayModeChanged;
            cal.DisplayMode = CalendarMode.Year;
        }
        private void EndPeriodPicker_Opened(object sender, RoutedEventArgs e)
        {
            DatePicker datepicker = (DatePicker)sender;
            Popup popup = (Popup)datepicker.Template.FindName("PART_Popup", datepicker);
            Calendar cal = (Calendar)popup.Child;
            cal.DisplayModeChanged += CalenderEnd_DisplayModeChanged;
            cal.DisplayMode = CalendarMode.Year;
        }

        private void CalenderStart_DisplayModeChanged(object sender, CalendarModeChangedEventArgs e)
        {
            Calendar calendar = (Calendar)sender;
            if (calendar.DisplayMode == CalendarMode.Month)
            {
                calendar.SelectedDate = calendar.DisplayDate;
                StartPeriodPicker.IsDropDownOpen = false;
            }
        }

        private void CalenderEnd_DisplayModeChanged(object sender, CalendarModeChangedEventArgs e)
        {
            Calendar calendar = (Calendar)sender;
            if (calendar.DisplayMode == CalendarMode.Month)
            {
                DateTime d = calendar.DisplayDate;
                int lastDay = DateTime.DaysInMonth(d.Year, d.Month);
                calendar.DisplayDate = new DateTime(d.Year, d.Month, lastDay);
                calendar.SelectedDate = calendar.DisplayDate;
                EndPeriodPicker.IsDropDownOpen = false;
            }
        }
    }
}
