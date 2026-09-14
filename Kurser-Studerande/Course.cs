//ska skriva kurser 
//först börja med en class

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
        if (Students.Count >= maxSeats + 1)
        {
            Console.WriteLine("Kursen är full");

        }

        Students.Add(student);
        Console.WriteLine("Studenten har anmälts till kursen");
    } 
  
  public void Remove(Student rstudents)
      {
        Students.Remove(rstudents);
    }
}
