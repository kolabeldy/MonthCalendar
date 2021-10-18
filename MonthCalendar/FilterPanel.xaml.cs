using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace MonthCalendar
{
    /// <summary>
    /// Логика взаимодействия для FilterPanel.xaml
    /// </summary>
    public partial class FilterPanel : UserControl
    {
        public FilterPanel()
        {
            InitializeComponent();
        }
        private void DatePickerStart_Opened(object sender, RoutedEventArgs e)
        {
            DatePicker datepicker = (DatePicker)sender;
            Popup popup = (Popup)datepicker.Template.FindName("PART_Popup", datepicker);
            Calendar cal = (Calendar)popup.Child;
            cal.DisplayModeChanged += CalenderStart_DisplayModeChanged;
            cal.DisplayMode = CalendarMode.Year;
        }
        private void DatePickerEnd_Opened(object sender, RoutedEventArgs e)
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
                YearPicker.IsDropDownOpen = false;
            }
        }

        private void CalenderEnd_DisplayModeChanged(object sender, CalendarModeChangedEventArgs e)
        {
            Calendar calendar = (Calendar)sender;
            if (calendar.DisplayMode == CalendarMode.Month)
            {
                calendar.SelectedDate = calendar.DisplayDate;
                YearPicker1.IsDropDownOpen = false;
            }
        }

        private void ClearOtherComboBox_Click(object sender, RoutedEventArgs e)
        {
            //IsAllOther.IsChecked = false;
            OtherComboBox.SelectedIndex = -1;
        }

        private void Tech1Clear_Click(object sender, RoutedEventArgs e)
        {
            Tech1ComboBox.SelectedIndex = -1;
        }

        private void MainClear_Click(object sender, RoutedEventArgs e)
        {
            MainComboBox.SelectedIndex = -1;
        }

        private void MainComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MainComboBox.SelectedIndex > 0)
            {
                Tech1ComboBox.SelectedIndex = -1;
                OtherComboBox.SelectedIndex = -1;
            }
        }

        private void Tech1ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Tech1ComboBox.SelectedIndex > 0)
            {
                OtherComboBox.SelectedIndex = -1;
                MainComboBox.SelectedIndex = -1;
            }
        }

        private void OtherComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OtherComboBox.SelectedIndex > 0)
            {
                Tech1ComboBox.SelectedIndex = -1;
                MainComboBox.SelectedIndex = -1;
            }
        }
        private void MainERComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MainERComboBox.SelectedIndex > 0)
            {
                SecondComboBox.SelectedIndex = -1;
            }
        }
        private void SecondComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SecondComboBox.SelectedIndex > 0)
            {
                MainERComboBox.SelectedIndex = -1;
            }
        }
        private void MainERClear_Click(object sender, RoutedEventArgs e)
        {
            MainERComboBox.SelectedIndex = -1;
        }
        private void SecondClear_Click(object sender, RoutedEventArgs e)
        {
            SecondComboBox.SelectedIndex = -1;
        }

        private void ProductClear_Click(object sender, RoutedEventArgs e)
        {
            ProductComboBox.SelectedIndex = -1;
        }

        private void ProductComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
