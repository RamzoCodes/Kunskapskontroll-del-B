Student Khalid = new("Khalid Arain");
Student Mehwash = new("Mehwash Chaudry");

Student Amar = new("Amar");
Student Yaser = new("Yaser");

Course Chemistry = new("Chemistry");


Chemistry.enroll(Khalid);
Chemistry.enroll(Mehwash);
Chemistry.enroll(Amar);
Chemistry.enroll(Yaser);

Chemistry.Remove(Yaser);

Console.WriteLine("Chemistry:\nStudent list;");

for (int i = 0; i< Chemistry.Students.Count; i++)
{
    Console.WriteLine(Chemistry.Students[i].Name);
}