using System.ComponentModel;

public class Student: INotifyPropertyChanged
{
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
    private string _Name;
    public string Name { 
        get => _Name; 
        set {
            if (value != _Name)
            {
                _Name = value;
                OnPropertyChanged();
            }
        }
    }

    private int _Id;
    public string Id { 
        get => _Id.ToString(); 
        set {
            var dv = int.Parse(value);
            if (dv != _Id)
            {
                _Id = dv;
                OnPropertyChanged();
            }
        }
    }
    private double _GPA;
    public string GPA { 
        get => _GPA.ToString(); 
        set
        {
            var dv = double.Parse(value);
            if (dv != _GPA)
            {
                _GPA = dv;
                OnPropertyChanged();
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged(string propertyName=null)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public override string ToString() =>
        $"{this.Name}\n{this.Id}\n{this.GPA}\n";
}