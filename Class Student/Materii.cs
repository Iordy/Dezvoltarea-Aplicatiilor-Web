using System;

namespace Materii_Namespace
{
	public class Materii
	{

		public string Profesor { get; set; }
		public string Semestru { get; set; }
		public int NumarOre { get; set; }
		public bool CerinteAnterioare { get; set; }


		public Materii()
		{
			Profesor = "null";
			Semestru = "null";
			NumarOre = 0;
			CerinteAnterioare = false;
		}

		public Materii(string profesor, string semestru, int numarOre, bool cerinteAnterioare)
		{
			Profesor = profesor;
			Semestru = semestru;
			NumarOre = numarOre;
			CerinteAnterioare = cerinteAnterioare;
		}



	}
}

