using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace AUpchurchW5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            lstEvents.Items.Clear();

            if (calEventCalendar.SelectedDate != null)
            {
                DateTime date = calEventCalendar.SelectedDate.Value;
                string selectedDate = date.Year + "-" + PadZero(date.Month) + "-" + PadZero(date.Day) + ".txt";

                if (File.Exists(selectedDate))
                {
                    string fileContent = File.ReadAllText(selectedDate);
                    int start = 0;

                    while (start < fileContent.Length)
                    {
                        int end = fileContent.IndexOf('\n', start);
                        if (end == -1)
                        {
                            lstEvents.Items.Add(fileContent.Substring(start));
                            break;
                        }
                        else
                        {
                            lstEvents.Items.Add(fileContent.Substring(start, end - start));
                            start = end + 1;
                        }
                    }
                }
            }
        }

        private void AddEventButton_Click(object sender, RoutedEventArgs e)
        {
            if (calEventCalendar.SelectedDate != null &&
                cbxStartTime.SelectedItem != null &&
                cbxEndTime.SelectedItem != null &&
                tbxEventName.Text != "")
            {
                DateTime date = calEventCalendar.SelectedDate.Value;
                string selectedDate = date.Year + "-" + PadZero(date.Month) + "-" + PadZero(date.Day) + ".txt";
                string startTime = ((ComboBoxItem)cbxStartTime.SelectedItem).Content.ToString();
                string endTime = ((ComboBoxItem)cbxEndTime.SelectedItem).Content.ToString();
                string eventName = tbxEventName.Text;
                string eventDetails = startTime + " - " + endTime + ": " + eventName;

                lstEvents.Items.Add(eventDetails);

                string fileContent = "";
                if (File.Exists(selectedDate))
                {
                    fileContent = File.ReadAllText(selectedDate);
                }
                fileContent += eventDetails + "\n";
                File.WriteAllText(selectedDate, fileContent);

                tbxEventName.Text = "";
                cbxStartTime.SelectedItem = null;
                cbxEndTime.SelectedItem = null;
            }
        }

        private void DeleteEventButton_Click(object sender, RoutedEventArgs e)
        {
            if (lstEvents.SelectedItem != null && calEventCalendar.SelectedDate != null)
            {
                DateTime date = calEventCalendar.SelectedDate.Value;
                string selectedDate = date.Year + "-" + PadZero(date.Month) + "-" + PadZero(date.Day) + ".txt";
                string selectedEvent = lstEvents.SelectedItem.ToString();

                lstEvents.Items.Remove(selectedEvent);

                if (File.Exists(selectedDate))
                {
                    string fileContent = File.ReadAllText(selectedDate);
                    string updatedContent = "";
                    int start = 0;

                    while (start < fileContent.Length)
                    {
                        int end = fileContent.IndexOf('\n', start);
                        if (end == -1)
                        {
                            string line = fileContent.Substring(start);
                            if (line != selectedEvent)
                            {
                                updatedContent += line + "\n";
                            }
                            break;
                        }
                        else
                        {
                            string line = fileContent.Substring(start, end - start);
                            if (line != selectedEvent)
                            {
                                updatedContent += line + "\n";
                            }
                            start = end + 1;
                        }
                    }

                    File.WriteAllText(selectedDate, updatedContent);
                }
            }
        }

        private void EventsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstEvents.SelectedItem != null)
            {
                btnDeleteEvent.IsEnabled = true;
            }
            else
            {
                btnDeleteEvent.IsEnabled = false;
            }
        }

        private string PadZero(int number)
        {
            if (number < 10)
            {
                return "0" + number;
            }
            return number + ""; // Changed from ToString() to string concatenation
        }
    }
}