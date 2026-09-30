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
		}
	}
}
