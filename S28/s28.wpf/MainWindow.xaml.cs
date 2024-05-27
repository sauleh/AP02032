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

namespace s28.wpf;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private Student s = new Student();
    public MainWindow()
    {
        InitializeComponent();
        this.btnView.Click += (_,_) => this.txtOutput.Text = s.ToString();
        this.btnUpdate.Click += (_, _) =>
        {
            s.Id = this.tbId.Text;
            s.GPA = this.tbGPA.Text;
            s.Name = this.tbName.Text;
        };

        // this.tbName.TextChanged += (_, a) =>
        // {
        //     s.Name = this.tbName.Text;
        // };

        Task.Run(() =>
        {
            while(true)
            {
                Task.Delay(5000).Wait();
                s.Name = s.Name.ToUpper();
                s.Id =  (int.Parse(s.Id) - 1).ToString();
                s.GPA = (double.Parse(s.GPA) + 0.01).ToString();
                Task.Delay(5000).Wait();
                s.Name = s.Name.ToLower();
                s.Id =  (int.Parse(s.Id) + 1).ToString();
                s.GPA = (double.Parse(s.GPA) - 0.01).ToString();
            }
        });

        this.DataContext = s;
    }
}