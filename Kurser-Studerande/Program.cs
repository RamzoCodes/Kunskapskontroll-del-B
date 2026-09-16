//Nedan är objekt som skapas av klassen "Student".
Student Omar = new("Omar Arain");
Student Lisa = new("Lisa Chaudry");
Student Amar = new("Amar Bhatt");
Student Yaser = new("Yaser Jatt");

//Nedan är objekt som skapas 
Course Chemistry = new("Chemistry");
Course English = new("English");
Course Swedish = new("Swedish");
Course Mathematics = new("Mathematics");
Course Physics = new("physics");


//Anropar Eleverna
Chemistry.enroll(Omar);
Chemistry.enroll(Lisa);
Chemistry.enroll(Amar);
Chemistry.enroll(Yaser);
English.enroll(Amar);
Mathematics.enroll(Amar);
Swedish.enroll(Yaser);
Physics.enroll(Lisa);
Physics.enroll(Omar);


//Tar bort eleven
Chemistry.Remove(Yaser);

Console.WriteLine("Chemistry:\nStudent list;");



Chemistry.RollCall();
