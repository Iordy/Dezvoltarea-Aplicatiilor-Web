using System;
using Materii_Namespace;
using Class_Student;
using System.Collections.Generic;


Materii mat2 = new("Dl. Laborantescu", "Sem 1", 4, false);

Materii mat3 = new("Dl. Cursantescu", "Sem 2", 6, true);




List<Materii> ore = new () { new Materii("Dl. Profesorescu", "Sem 1", 5, true), mat2, mat3 };

Student st1 = new (1,"Andrei",ore);

st1.ShowDiscipline();

Console.ReadKey();




