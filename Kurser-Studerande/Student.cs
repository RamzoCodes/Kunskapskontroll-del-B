//Mallen för ALLA elever
using System.Runtime.CompilerServices;

public class Student //"Public" betyder att andra filer kan se den. Detta skapar mallen för alla studenter i programmet. "Class" är programmeringsord för mall, liksom blueprint, man kan likna det med en blueprint för ett hus.

{
    public string Name; //En fält för studentens namn. fältet består av text, vilket är varför vi säger string.

    public List<Course> Course = []; // Skapar en tom lista som kan hålla course-relaterade objekt.
    public Student(string name) // Detta är en Constructor. Om class är mallen, då är detta en arbetare. Den körs helt automatiskt när objektet skapas (när vi skriver "new" och syftet är att ge objektet sina startvärden.)
    {
        Name = name; //Sparar Studentens namn i objektets variabel.
    }
    public override string ToString() // 
    {
        return Name;
    }

    public void Join(Course courseName) // En metod för att gå med i en kurs. Tar emot objekt som vi har döpt till courseName.
    {
        if (!Course.Contains(courseName)) //Om studentens lista inte redan innehåller denna kurs
        {
            Course.Add(courseName);
            courseName.Students.Add(this); //Då lägg till kursen i elevens lista
        }
        else //annars
        {
            Console.WriteLine("Finns I kursen!"); //Ser vi detta.

        }
    }

    public void Leave(Course courseName) //En annan metod för att lämna kursen
    {
        Course.Remove(courseName); //Simpelt, Course remove = ta bort kurs.
        courseName.Students.Remove(this); //ta bort DENNA SPECIFIKA studenten ur listan.
    }
    public void Schedule(Course courseName) // Skriver ut de olika kurserna som studenten har, studentens schema.
    {
        foreach (var Courses in Course) //Loopar genom Course-listan.
        {
            Console.WriteLine("Schedule:");
        }
    }
}