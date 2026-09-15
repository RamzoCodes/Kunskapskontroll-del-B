//Nedan är objekt
Student Omar = new("Omar Arain");
Student Lisa = new("Lisa Chaudry");

Student Amar = new("Amar Bhatt");
Student Yaser = new("Yaser Jatt");

//Kursen som en objekt
Course Chemistry = new("Chemistry");

//Anropar Eleverna
Chemistry.enroll(Omar);
Chemistry.enroll(Lisa);
Chemistry.enroll(Amar);
Chemistry.enroll(Yaser);

//Tar bort eleven
Chemistry.Remove(Yaser);

Console.WriteLine("Chemistry:\nStudent list;");

Chemistry.RollCall();
