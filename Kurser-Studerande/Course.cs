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
        if (Students.Count>= maxSeats)
        {
            return;
        }
        
        Students.Add(student);
    } 
    //if finns plats, då anmäla till kursen. else säga finns inte plats
}
