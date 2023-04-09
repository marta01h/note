using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Xml.Serialization;

namespace _1namespace WpfApplication3
{
    [Serializable]
public class Task
{
    public string ToDo { get; set; }
    public DateTime Time { get; set; }
    public Task() { }

}

[Serializable]
public class Day
{
    public List<Task> ListTasks { set; get; }
    public DateTime Date { get; set; }
    public Day() { }

}

public partial class MainWindow : Window
{

    List<Day> lst = new List<Day>();

    public MainWindow()
    {
        InitializeComponent();

    }


    private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
    {

        var calendar = sender as Calendar;

        if (calendar.SelectedDate.HasValue)
        {

            var arDays = this.lst.Where(x => calendar.SelectedDate.Value.Date == x.Date).Cast<Day>();
            foreach (var oneDay in arDays)
            {
                int iCount = 0;
                foreach (TextBox tb in this.StEdits.Children.Cast<TextBox>())
                    tb.Text = oneDay.ListTasks[iCount++].ToDo;

            }

        }

    }

    void Serialize()
    {
        try
        {
            using (FileStream fs = new FileStream("1.xml", FileMode.OpenOrCreate, FileAccess.Write))
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Day>));
                xml.Serialize(fs, lst);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    void Deserialize()
    {
        try
        {
            using (FileStream fs = new FileStream("1.xml", FileMode.Open, FileAccess.Read))
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Day>));
                this.lst = (List<Day>)xml.Deserialize(fs);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

}
}

{
    internal class Class2
    {
    }
}
