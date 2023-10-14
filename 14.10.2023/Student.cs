
class Student
{
    public string Name;
    public string SurName;
    public double Group;
    public int Point;
    public Boolean isGraduated;


    public void GetName(string Name, string SurName)
    {
        Console.WriteLine($"Name:{Name}, Surname:{SurName}");
    }

    public void GetValue(double Group,int Point,Boolean isGraduated)
    {
        if ( isGraduated ) 
        {
            Console.WriteLine($"Qrup:{Group}, Bal:{Point}, Mezundur");
        }
        else
        {
            Console.WriteLine($"Qrup:{Group}, Bal:{Point}, Mezun deyildir");
        }
    }

    public void EnterExam()
    {
        if (Point > 80)
        {
            Console.WriteLine("Ikinci imtahana girə bilər :)");
        }
        else
        {
            Console.WriteLine("Ikinci imtahana kifayət qədər bal toplamamısız :(");
        }
    }
}

