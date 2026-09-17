//Nedan är objekt som skapas av klassen "Student".
Student Omar = new("Omar Arain");
Student Lisa = new("Lisa Chaudry");
Student Amar = new("Amar Bhatt");
Student Yaser = new("Yaser Jatt");
Student Ramez = new("Ramez Johansson");
Student Karl = new("Karl Lustav");

//Nedan är kurser som skapas (objekt)
Course Chemistry = new("Chemistry");
Course English = new("English");
Course Swedish = new("Swedish");


Chemistry.enroll(Omar);
Lisa.Join(Chemistry);
Chemistry.enroll(Ramez);
Chemistry.enroll(Yaser);
Chemistry.enroll(Amar);

Karl.Join(Chemistry); //denna ska nekas pga kursen är full.

Console.WriteLine(); //ger lite mellanrum så vi kan läsa bättre

Chemistry.enroll(Ramez); //detta ska ge felmeddelande om dubbelanmälan

Console.WriteLine();

English.enroll(Amar); // Nu går Amar i två kurser
Amar.Schedule(); //visar amars schema samt platserna i kurserna

Console.WriteLine();

Chemistry.Remove(Omar); //Omar tas bort från kursen
Ramez.Leave(Chemistry); //Ramez lämnar själv
Ramez.Schedule(); //Ramez har tom schema >:(

Console.WriteLine();

Chemistry.Remove(Karl); //programmet kraschar inte om vi försöker ta bort någon som inte är med i kursen.

Console.WriteLine();
Chemistry.RollCall();

