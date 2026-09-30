using System;
using System.Collections.Generic;
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
		}
	}
}
