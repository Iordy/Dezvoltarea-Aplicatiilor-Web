using System;
using System.Collections.Generic;

using Materii_Namespace;

namespace Class_Student
{
	public class Student
	{

		private int AnStudiu { get; set; }
		private string Nume { get; set; }

		public List<Materii> Discipline;



		public Student()
		{
			Nume = "null";
			AnStudiu = 1;
			Discipline = new List<Materii>();
		}

		public Student(int anStudiu, string nume, List <Materii> discipline)
		{
			Nume = nume;
			AnStudiu = anStudiu;
            Discipline = new List<Materii>();

			foreach (Materii m in discipline)
				Discipline.Add(m);
		}

		public void ShowDiscipline()
		{
			foreach(Materii m in Discipline)
			{ Console.WriteLine(m.Profesor + m.Semestru + m.CerinteAnterioare + m.NumarOre); }
		}


	}
}

