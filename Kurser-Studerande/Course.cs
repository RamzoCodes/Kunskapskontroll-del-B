//Mallen för ALLA kurser

public class Course
{
    public string? Name;

    public int maxSeats=5;

    public Course (string name) //konstruktör
    {
        Name = name;
    }

    public List<Student> Students = []; //kommer dra från student.cs

    public void enroll(Student student)
    {
        if (Students.Count >= maxSeats || Students.Contains(student))
        {
            Console.WriteLine("Kursen är full");

        }
        else
        {
            Students.Add(student);
            student.Course.Add(this); //lägger till från båda håll
        Console.WriteLine("Studenten har anmälts till kursen");
        }
        
    }

    public void Remove(Student rstudents)
    {
        Students.Remove(rstudents);
    }

    public void RollCall() //Skriver ut alla studerande i kursen med hjälp av for loop!
    {
        for (int i = 0; i < Students.Count; i++)
        {
            Console.WriteLine(Students[i].Name);
        }
    }
    
}
