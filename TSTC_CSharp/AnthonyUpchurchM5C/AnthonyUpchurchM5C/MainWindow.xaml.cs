using System.Windows.Controls;
using System.Windows;
using System.Diagnostics;
using System;
using System.IO;

namespace AnthonyUpchurchM5C
{
    public partial class MainWindow : Window
    {
        private readonly string filePath;
        public MainWindow()
        {
            InitializeComponent();

            filePath = "EmployeeSchedule.txt";

            LoadScheduleFile();
        }

        private void btnEmployee1_Click(object sender, RoutedEventArgs e)
        {
            AddSchedule("Anthony", lstEmployee1);
        }

        private void btnEmployee2_Click(object sender, RoutedEventArgs e)
        {
            AddSchedule("Jane", lstEmployee2);
        }

        private void btnEmployee3_Click(object sender, RoutedEventArgs e)
        {
            AddSchedule("Alejandro", lstEmployee3);
        }

        private void AddSchedule(string employeeName, ListBox employeeListBox)
        {
            if (calendar.SelectedDate == null)
            {
                MessageBox.Show("Please select a valid date from the calendar.");
                return;
            }

            if (cmbStartTime.SelectedIndex < 0 || cmbEndTime.SelectedIndex < 0)
            {
                MessageBox.Show("Please select both start and end times.");
                return;
            }

            string date = calendar.SelectedDate.Value.ToShortDateString();
            string startTime = (cmbStartTime.SelectedItem as ComboBoxItem)?.Content.ToString();
            string endTime = (cmbEndTime.SelectedItem as ComboBoxItem)?.Content.ToString();

            string scheduleEntry = $"{employeeName}: {date} {startTime} - {endTime}";


            lstMainSchedule.Items.Add(scheduleEntry);


            employeeListBox.Items.Add($"{date} {startTime} - {endTime}");

            WriteScheduleFile(scheduleEntry);
        }

        private void LoadScheduleFile()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string[] scheduleEntries = File.ReadAllLines(filePath);

                    foreach (string entry in scheduleEntries)
                    {
                        lstMainSchedule.Items.Add(entry);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading from file: {ex.Message}");
            }
        }

        private void WriteScheduleFile(string scheduleEntry)
        {
            try
            {
                File.AppendAllText(filePath, scheduleEntry + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to file: {ex.Message}");
            }
        }
    }
}