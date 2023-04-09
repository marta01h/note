using System.Timers;
using System.Windows.Controls;
using System.Windows;
using System;

public partial class MainWindow : Window
{

    public MainWindow()
    {
        InitializeComponent();
        Timer t = new Timer(1000);
        t.Elapsed += T_Elapsed;
        t.Start();
    }

    private void T_Elapsed(object sender, ElapsedEventArgs e)
    {
        DateTime ci = DateTime.Now;
        this.Dispatcher.Invoke(new Action(() => this.Label1.Content = ci.ToLongTimeString()));
    }

    private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
    {
        // ... Get reference.
        var calendar = sender as Calendar;

        // ... See if a date is selected.
        if (calendar.SelectedDate.HasValue)
        {
            // ... Display SelectedDate in Title.
            DateTime date = calendar.SelectedDate.Value;
            this.Title = date.ToShortDateString();

        }

    }