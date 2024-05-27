using System.ComponentModel;

public class Student : INotifyPropertyChanged
{
    private string _Name;
    public string Name { 
        get => _Name; 
        set {
            if (value != _Name)
            {
                _Name = value;
                OnPropertyChanged();
            }
        } }

    private int _Id;
    public string Id { 
        get => _Id.ToString(); 
        set
        {
            var id = int.Parse(value);
            if (_Id != id)
            {
                _Id = id;
                OnPropertyChanged();
            }
        }
    }

    private void OnPropertyChanged()
    {
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
    }

    private double _GPA;

    public event PropertyChangedEventHandler PropertyChanged;

    public string GPA { 
        get => _GPA.ToString(); 
        set
        {
            var gpa = double.Parse(value);
            if (gpa != _GPA)
            {
                _GPA = gpa;
                OnPropertyChanged();
            }
        } 
    }
    public Student()
    {
        this.Name = string.Empty;
        this._Id = 0;
        this._GPA = 0.0;
    }

    public Student(string name, int id, double gpa)
    {
        this.Name = name;
        this._Id = id;
        this._GPA = gpa;
    }
    public override string ToString() =>
        $"{this.Name}\n{this.Id}\n{this.GPA}\n";
}