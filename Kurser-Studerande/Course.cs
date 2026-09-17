//Mallen för ALLA kurser

using System.ComponentModel.DataAnnotations;

public class Course //mallen för kurser i programmet.
{
    public string? courseName; // Kursens namn. Frågetecken för att det från början får vara tomt (null)

    public int maxSeats=5; //Variabel som bestämmer max antar platser i kursen. Jag angav 5 för att efterlikna ett exempel i uppgiftens instruktioner

    public Course (string name) //konstruktören som körs när vi skriver "new Course()"
    {
        courseName = name; //Sparar namnet på kursen.
    }

    public List<Student> Students = []; //Tom lista som innehåller student-objekt.

    public void enroll(Student student) //Detta är metoden för att anmäla studenten till kursen.
    {
      
        if (Students.Contains(student)) //Eleven finns redan
        {
            Console.WriteLine($"{student.studentName} finns redan i {courseName}!");
        }
       
        else if 
(Students.Count >= maxSeats) // OM antal studenter i kursen har nått gränsen (maxSeats)
        {
            Console.WriteLine($"{courseName} är full. {student.studentName} kan inte anmälas till kursen"); //Så skrivs detta ut
        }
       
        else
        {
            Students.Add(student); //Lägg till studenten i kursens lista

            if (!student.Course.Contains(this))
            {
                student.Course.Add(this);
            // Gå till studentens lista och lägg till denna(this) kursen
            }
            Console.WriteLine($"{student.studentName} har lagts till i {courseName}.");
        }
        
    }

    public void Remove(Student removeStudents) //Detta är metoden för att ta bort studenten från kursen
    {
        Students.Remove(removeStudents); //Tar bort eleven från kursen 
        removeStudents.Course.Remove(this); //Tar bort från både kursens lista av elever och elevens lista av kurser.
    }

    public void RollCall() //Skriver ut alla studerande i kursen med hjälp av for loop!
    {
        for (int i = 0; i < Students.Count; i++)
        {
            Console.WriteLine(Students[i].studentName);
        }
    }

    public override string ToString()
    {
        return ($"{courseName} ({Students.Count}/{maxSeats}) platser");
    }
}
