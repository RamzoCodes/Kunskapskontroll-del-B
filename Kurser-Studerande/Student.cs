//Mallen för ALLA elever
using System.Runtime.CompilerServices;

public class Student
{
    //en property som kan lagra text
    public string Name;
    public List<Course> Course = [];
    public Student(string name) // this is how a konstroctur is made.
    {
        Name = name;
    }

    public void Join(Course courseName)
    {
        if (!Course.Contains(courseName))
        {
          Course.Add(courseName);
        courseName.Students.Add(this);   
        }
        else
         {
            Console.WriteLine("Finns I kursen!");
            
        }
    }

public void Leave(Course courseName)
    {
        Course.Remove(courseName);
    }

}