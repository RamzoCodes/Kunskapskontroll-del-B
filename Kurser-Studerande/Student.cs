//Mallen för ALLA elever
using System.Runtime.CompilerServices;

public class Student //"Public" betyder att andra filer kan se den. Detta skapar mallen för alla studenter i programmet. "Class" är programmeringsord för mall, liksom blueprint, man kan likna det med en blueprint för ett hus.

{
    public string studentName; //En fält för studentens namn. fältet består av text, vilket är varför vi säger string.

    public List<Course> Course = []; // Skapar en tom lista som kan hålla course-relaterade objekt.
    public Student(string name) // Detta är en Constructor. Om class är mallen, då är detta en arbetare. Den körs helt automatiskt när objektet skapas (när vi skriver "new" och syftet är att ge objektet sina startvärden.)
    {
        studentName = name; //Sparar Studentens namn i objektets variabel.
    }
    public override string ToString() // 
    {
        return studentName;
    }

    public void Join(Course courseName) // En metod för att gå med i en kurs. Tar emot objekt som vi har döpt till courseName.
    {
        courseName.enroll(this);
    }

    public void Leave(Course RemovecourseName) //En annan metod för att lämna kursen
    {
        Course.Remove(RemovecourseName); //Simpelt, Course remove = ta bort kurs.
        RemovecourseName.Students.Remove(this); //ta bort DENNA SPECIFIKA studenten ur listan.
    }
    public void Schedule() // Skriver ut de olika kurserna som studenten har, studentens schema.
    {
        Console.WriteLine($"{studentName}s Schema");
        
        if (Course.Count == 0)
        {
            Console.WriteLine($"{studentName} är inte med i någon kurs");

        }
        else
        {
        foreach (var Courses in Course) //Loopar genom Course-listan.
        {
            Console.WriteLine($"Schedule: {Courses}");
        }
        }
    }
}