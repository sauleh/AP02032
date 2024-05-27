using System.Reflection.Metadata;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace s28.wpf2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // private void HandleClick(object sender, RoutedEventArgs a)
    // {
    //     this.tbOutput.Text = s.ToString();
    // }
    private Student s = new Student();
    public MainWindow()
    {
        InitializeComponent();
        this.btnView.Click += (_,_) => this.tbOutput.Text = s.ToString();
        this.DataContext = s;
        // s.PropertyChanged += (_, _) => { };
        // this.tbName.TextChanged += (_, _) => s.Name = this.tbName.Text;
        // this.tbId.TextChanged += (_, _) => s.Id = int.Parse(this.tbId.Text);
        // this.tbGPA.TextChanged += (_, _) => s.GPA = double.Parse(this.tbGPA.Text);
        // this.btnUpdate.Click += (_, _) =>
        // {
        //     s.Name = this.tbName.Text;
        //     s.Id = int.Parse(this.tbId.Text);
        //     s.GPA = double.Parse(this.tbGPA.Text);
        // };
        Thread t = new Thread(() =>
        {
            while(true)
            {
                Thread.Sleep(1000);
                s.Name += ".";
                s.Id = (int.Parse(s.Id) + 1).ToString();
                s.GPA = (double.Parse(s.GPA) + 0.1).ToString();
            }
        });
        t.Start();
    }
}