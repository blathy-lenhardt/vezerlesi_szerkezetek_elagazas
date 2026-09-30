using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezerlesi_szerkezetek_elagazas
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 1. szekvencia
			// 2. elágazás
			// 3. ciklus

			/* 1. szekvencia
			 * Egymás után megszabott sorrendben végrehajtott utasításokból áll.
			 * Pl.:	az úszóverseny mozzanatai
			 *	int a = 2;
			 *	int b = 3;
			 *	int c = b - a;
			 */

			/* 2. ELÁGAZÁS (szelekció)
			 * Olyan vezérlési szerkezet, amely az utasítások egy adott csoportját attól függően hajtja végre,
			 *	hogy egy adott logikai feltétel teljesül-e.
			 * Fajtái: Egyirányű, kétirányú, többirányú.
			 */

			/* EGYIRÁNYÚ ELÁGAZÁS
			 * Algoritmusa:
			 *	Ha logikai feltétel akkor utasítás(ok)
			 *	Elágazás vége
			 *	
			 * Megjegyzés:
			 *	- logikai feltétel bármilyen kifejezés lehet, eredménye logikai (igaz, hamis) lesz
			 * C#:
			 *	if (logikai feltétel) {
			 *		utasítás(ok);
			 *	}
			 */

			/* KÉTIRÁNYÚ ELÁGAZÁS
			 * Algoritmus:
			 *	Ha logikai feltétel akkor utasítás(ok)
			 *	különben utasítás(ok)
			 *	Elágazás vége
			 * C#:
			 *	if (logikai feltétel) {
			 *		utasítás(ok);
			 *	} else {
			 *		utasítás(ok);
			 *	}
			 */

			/* 1. PÉLDA:
			 * Készítsünk egy egyszerű programot, amely bekéri a felhasználó életkorát. Ha nincs 18 írjuk ki, hogy kiskorú!
			 */

			Console.Write("Életkor: ");
			int age = Convert.ToInt32(Console.ReadLine());
			if (age < 18) {
				Console.WriteLine("Kiskorú!");
			}

			/* 2. PÉLDA:
			 * Készítsünk egy egyszerű programot, amely bekér a felhasználótól egy számot! Döntsük el, hogy páros, vagy páratlan!
			 */

			Console.Write("Adjon meg egy egész számot: ");
			int num = Convert.ToInt32(Console.ReadLine());
			if (num % 2 == 0)
			{
				Console.WriteLine("Páros!");
			}
			else
			{
				Console.WriteLine("Páratlan!");
			}

			/* TÖBBIRÁNYÚ ELÁGAZÁS
			 * Ha logikai feltétel akkor utasítás1
			 * különben Ha logikai feltétel2 akkor utasítás2
			 * különben Ha logikai feltétel3 akkor utasítás3
			 * különben utasítás4
			 * 
			 * if (logikai feltétel) {
			 *	utasítás1;
			 * } else if (logikai feltétel2) {
			 *	utasítás2;
			 * } else if (logikai feltétel3) {
			 *	utasítás3;
			 * } else {
			 *	utasítás4;
			 * }
			 * 
			 * Algoritmus:
			 * Elágazás
			 *	logikai feltétel1 esetén utasítás1
			 *	logikai feltétel2 esetén utasítás2
			 *	logikai feltétel3 esetén utasítás3
			 *	...
			 * Elágazás vége
			 * 
			 * C#-ban:
			 *	switch ()
			 *	{
			 *		case logikai feltétel1:
			 *			utasítás1;
			 *			break;
			 *		case logikai feltétel2:
			 *			utasítás2;
			 *			break;
			 *		case logikai feltétel3:
			 *			utasítás3;
			 *			break;
			 *		default:
			 *			alap utasítás;
			 *			break;
			 *	}
			 * 
			 * Megjegyzés:
			 *	- switch: melyik változó után történik meg az esetek szétválasztása (egész, karakter, szöveg, logikai, felsorolás)
			 *	- case: az egyes esetek jelölése
			 *	- case kulcsszó után megadjuk az utasításokat
			 *	- break: ezzel jelezzük, hogy az elágazásból ki akarunk lépni
			 *	- default: lehetséges eseteken kívüli esetet is kezelni szeretnénk
			 */

			/* 3. PÉLDA
			 * Egy számmal beírt érdemjegyhez ki szeretnénk írni a szöveges változatát!
			 */
			Console.Write("Adja meg az érdemjegyet: ");
			int jegy = Convert.ToInt32(Console.ReadLine());
			string sjegy;
			switch (jegy)
			{
				case 1:
					sjegy = "Elégtelen";
					break;
				case 2:
					sjegy = "Elégséges";
					break;
				case 3:
					sjegy = "Közepes";
					break;
				case 4:
					sjegy = "Jó";
					break;
				case 5:
					sjegy = "Jeles";
					break;
				default:
					sjegy = "Hiba, rossz érték!";
					break;
			}
			Console.WriteLine(sjegy);

			// 1. feladat: Kérjünk be egy egész számot a billentyűzetről,
			//	és ha a szám nagyobb, mint 0, akkor írjuk ki a képernyőre, hogy "A szám pozitív!"!
			int num1;
			Console.WriteLine("1. feladat");
			Console.Write("Adjon meg egy egész számot: ");
			num1 = Convert.ToInt32(Console.ReadLine());
			if (num1 > 0)
			{
				Console.WriteLine("A szám pozitív!");
			}

			// 2. feladat: Kérjük be a másodfokú egyenlet együtthatóit és számítsuk ki a gyököket 2 tizedes pontossággal!
			//	Ha a diszkrimináns értéke negatív, írjuk ki a képernyőre: "Nincs megoldás!"!
			double a, b, c, d, x1, x2;
			Console.WriteLine("2. feladat");
			Console.Write("a: ");
			a = Convert.ToDouble(Console.ReadLine());
			Console.Write("b: ");
			b = Convert.ToDouble(Console.ReadLine());
			Console.Write("c: ");
			c = Convert.ToDouble(Console.ReadLine());

			d = Math.Pow(b, 2) - 4 * a * c;
			if (d < 0)
			{
				Console.WriteLine("Nincs megoldás!");
			}
			else
			{
				x1 = Math.Round(((b * -1 + Math.Sqrt(d)) / 2 * a), 2);
				x2 = Math.Round(((b * -1 - Math.Sqrt(d)) / 2 * a), 2);
				Console.WriteLine("x1 = {0}\nx2 = {1}", x1, x2);
			}

			// 3. feladat: Kérjünk be 2 számot. Írjuk a képernyőre a nagyobbat!
			int a3, b3;
			Console.WriteLine("3. feladat");
			Console.Write("Adjon meg egy számot: ");
			a3 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Adjon meg egy számot: ");
			b3 = Convert.ToInt32(Console.ReadLine());
			if (a3 > b3)
			{
				Console.WriteLine(a3);
			}
			else
			{
				Console.WriteLine(b3);
			}

			// 4. feladat: Írjuk ki 2 tetszőleges szám hányadosát. (Nullával nem lehet osztani!)
			int a4, b4, c4;
			Console.WriteLine("4. feladat");
			Console.Write("Adjon meg egy számot: ");
			a4 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Adjon meg egy számot: ");
			b4 = Convert.ToInt32(Console.ReadLine());
			if (b4 == 0)
			{
				Console.WriteLine("Nullával nem lehet osztani!");
			} else
			{
				c4 = a4 / b4;
				Console.WriteLine("{0} / {1} = {2}", a4, b4, c4);
			}

			// 5. feladat: Három tetszőleges számról döntsük el, hogy lehetnek-e egy háromszög oldalai.
			double a5, b5, c5;
			Console.WriteLine("5. feladat");
			Console.Write("Adja meg a háromszög első oldalát: ");
			a5 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Adja meg a háromszög második oldalát: ");
			b5 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Adja meg a háromszög harmadik oldalát: ");
			c5 = Convert.ToDouble(Console.ReadLine());
			if (a5 + b5 > c5 && a5 + c5 > b5 && b5 + c5 > a5)
			{
				Console.WriteLine("A háromszög valós.");
			}
			else
			{
				Console.WriteLine("A háromszög nem valós.");
			}
		}
	}
}
