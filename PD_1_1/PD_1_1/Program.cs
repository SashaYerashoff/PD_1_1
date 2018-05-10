using System;

namespace PD_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string yesno = "y"; //šeit yesno mainīgajam ir piešķirta "y" vērtība, lai cilpe vispār sāktu pildīties

            while (yesno == "y") //Šīs cilpes operators tiek izmantots lai pārbaudes laikā nevajadzētu katram nosacījumam palaist konsoli no jauna
            {
                Console.WriteLine("Uzdevums 1 un 6");
                string userID = Uzdevums1(); //pats uzdevums ir zemāk, atsevišķā funkcijā, lai kods būtu lasāmāks (papildus šī funkcija atgriež vērtību vārds+uzvārds, kuru var izmatot citur)
                Console.WriteLine();

                Console.WriteLine("Uzdevums 2");
                int userAge = Uzdevums2(userID); //Līdzīgi pirmam uzdevumam "globalizējam" vecumu ar return
                Console.WriteLine();

                Console.WriteLine("Uzdevums 3");
                Uzdevums3(); //pats uzdevums ir zemāk, atsevišķā funkcijā, lai kods būtu lasāmāks
                Console.WriteLine();

                Console.WriteLine("Uzdevums 4");
                Uzdevums4(); //pats uzdevums ir zemāk, atsevišķā funkcijā, lai kods būtu lasāmāks
                Console.WriteLine();

                Console.WriteLine("Uzdevums 5");
                Uzdevums5(); //pats uzdevums ir zemāk, atsevišķā funkcijā, lai kods būtu lasāmāks
                Console.WriteLine();

                Console.WriteLine("vēlies atkartot visus uzdevumus no jauna? (y/n)");
                yesno = Console.ReadLine();

                if (yesno == "y") //ja yesno nav vienāds ar "y", tad cilpe tiek pārtraukta
                {
                    Console.WriteLine("Vēlies attīrīt ekrānu?(y/n)");
                    string yesno2 = Console.ReadLine();
                    if (yesno2 == "y")
                    {
                        Console.Clear(); // Ar šo var nodzest visu iepriekšējo izvadu no konsoles
                    }
                }
            }

        }

        //uzdevuma 1 saturs iekš funkcijas
        static string Uzdevums1()
        {
            string vardsuzvards = "";
            Console.WriteLine("Vai gribat sasveicināties? (y/n)");
            string yesno = Console.ReadLine();
            if (yesno == "n")
            {
                Console.WriteLine("žēl gan!");
            }
            else
            {
                Console.WriteLine("Forši! Lūdzu ievadiet savu Vārdu: ");
                string vards = Console.ReadLine();
                Console.WriteLine("Paldies! Tagad lūdzu ievadiet savu Uzvārdu: ");
                string uzvards = Console.ReadLine();
                vardsuzvards = vards + " " + uzvards;
                Console.WriteLine("Ļoti patīkami {0}! Esmu C# Programma", vardsuzvards);

            }
            return vardsuzvards;
        }
        //uzdevuma 2 saturs iekš funkcijas
        static int Uzdevums2(string userID)
        {
            int tekossgads, dzimgads, vecums;
            Console.WriteLine("Lūdzu ievadiet tekošo gadu (piem. 2018): ");
            tekossgads = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Kāds ir jūsu dzimšanas gads?(piem. 1892): ");
            dzimgads = Convert.ToInt16(Console.ReadLine());

            vecums = tekossgads - dzimgads;
            Console.WriteLine("{0}, Jūsu vecums ir {1} gadi", userID, vecums);

            return vecums;
        }
        //uzdevuma 3 saturs iekš funkcijas
        static void Uzdevums3()
        {
            double radiuss, diametrs, laukums;
            Console.WriteLine("Tagad piedāvāju paskaitīt. Ievadiet lūdzu riņka līnijas radiusu: ");
            radiuss = Convert.ToDouble(Console.ReadLine());

            diametrs = 2 * 3.14 * radiuss;
            laukums = radiuss * radiuss * 3.14;
            Console.WriteLine("Jūsu riņķa diametrs = {0} un laukums = {1}", diametrs, laukums);
        }
        //uzdevuma 4 saturs iekš funkcijas
        static void Uzdevums4()
        {
            Console.WriteLine("Lūdzu ievadiet jebkuru skaitli: ");
            double skaitlis = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mans skaitlis ir({0})", skaitlis);
        }
        //uzdevuma 5 saturs iekš funkcijas
        static void Uzdevums5()
        {
            string texts1 = "macos programmet", texts2;
            Console.WriteLine("Ievadiet lūdzu: {0}", texts1);
            texts2 = Console.ReadLine();
            if (texts1 == texts2) //ar šo if pārbaudam vai ievadītais sakrīt ar nosacījumu
            {
                Console.WriteLine("Vau! Tev sanāca!");
            }
            else
            {
                while (texts1 != texts2) // Ar šo cilpu dodam iespēju pamēģināt savus spēkus vēlreiz 5 uzdevuma pildīšanā, gadījumā ja lietotājs to vēlās
                {
                    Console.WriteLine("Diemžēl kāds no mums sačakarējies meistarībā :(");
                    Console.WriteLine("Velies atkartot? (y/n)");
                    string yesno = Console.ReadLine();
                    if (yesno != "y")
                    {
                        Console.WriteLine("Paldies ka izmantoji mani, žēl ka mums tomēr nesanāca :(");
                        break; // ar šo break ejam ārā no cilpas, ja lietotājs nevēlās turpināt
                    }
                    else
                    {
                        Console.WriteLine("Ievadi lūdzu: {0}", texts1);
                        texts2 = Console.ReadLine();

                        if (texts1 == texts2) //ar šo "if" izvadam uzrakstu par sekmīgo uzdevuma izpildi, ja uzdevums ir izpildīts ne no pirmas reizes
                        {
                            Console.WriteLine("Vau! Tev tomēr sanāca!");
                        }
                    }
                }

            }



        }
    }
}