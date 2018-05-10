using System;

namespace PD_1_1
{
	class Program
	{
		static void Main(string[] args)
		{
			string userID = Uzdevums1(); //Uzdevums1 palaišana un vārda un uzvārda "globalizācija"
			int userAge = Uzdevums2(userID);
			Uzdevums3();
			Uzdevums4();
		}

		//uzdevums 1 iekš funkcijas
		static string Uzdevums1()
		{
			string vardsuzvards = "";
			Console.WriteLine("Vai gribat sasveicināties?");
			string yesno = Console.ReadLine();
			if (yesno == "no")
			{
				Console.WriteLine("žēl gan!");
			}
			else
			{
				Console.WriteLine("Froši! Lūdzu ievadiet savu Vārdu: ");
				string vards = Console.ReadLine();
				Console.WriteLine("Paldies! Tagad lūdzu ievadiet savu Uzvārdu: ");
				string uzvards = Console.ReadLine();
				vardsuzvards = vards + " " + uzvards;
				Console.WriteLine("Ļoti patīkami {0}! Esmu C# Programma", vardsuzvards);

			}
			return vardsuzvards;
		}
		//uzdevums 2 iekš funkcijas
		static int Uzdevums2( string userID)
		{
			int tekossgads, dzimgads, vecums;
			Console.WriteLine("Lūdzu ievadiet tekošo gadu (piem. 2018): ");
			tekossgads = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Kāds ir jūsu dzimšanas gads?(piem. 1892): ");
			dzimgads = Convert.ToInt16(Console.ReadLine());

			vecums = tekossgads - dzimgads;
			Console.WriteLine("{0}, Jūsu vecums ir {1} gadi",userID, vecums);

			return vecums;
		}
		//uzdevums 3 iekš funkcijas
		static void Uzdevums3()
		{
			double radiuss, diametrs, laukums;
			Console.WriteLine("Tagad piedāvāju paskaitīt. Ievadiet lūdzu riņka līnijas radiusu: ");
			radiuss = Convert.ToDouble(Console.ReadLine());

			diametrs = 2 * 3.14 * radiuss;
			laukums = radiuss * radiuss * 3.14;
			Console.WriteLine("Jūsu riņķa diametrs = {0} un laukums = {1}", diametrs, laukums);
		}
		//uzdevums 4 
		static void Uzdevums4()
		{
			Console.WriteLine("Lūdzu ievadiet jebkuru skatli: ");
			double skaitlis = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Mans skaitlis ir({0})", skaitlis);
		}
	}
}
