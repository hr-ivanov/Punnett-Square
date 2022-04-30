/*
 * Created by SharpDevelop.
 * User: Stan
 * Date: 27.12.2020 г.
 * Time: 19:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace Hybrids
{
	public class Hybrids
	{
		//Генотиповете на родителите се въвеждат като низове
		string first, second;
		public Hybrids(string f, string s)
		{
			first = f;
			second = s;
		}
		public void GetGametes(ref List <string> fgam, ref List <string> sgam)
		{
			/*Определяне на броя на гаметите: Ако индивидът е хетерозиготен по даден белег (т.е. има и главна, и малка буква (напр. Аа)),
			броят на възможните гамети се удвоява*/
			int fbr=1;
			for (int i = 0; i < first.Length; i+=2)
			{
				if (first[i]!=first[i+1])
				{
					fbr*=2;
				}
			}
			int sbr=1;
			for (int i = 0; i < second.Length; i+=2)
			{
				if (second[i]!=second[i+1])
				{
					sbr*=2;
				}
			}
			
			/*Определяне на самите гамети като набор от букви с дължина точно два пъти по-малка от генотипа на родителите.
			Тъй като белезите се унаследяват независимо един от друг, всяка гамета (полова клетка) представлява съвкупност от
			случйно избрани букви от генотипа на родителя, в която присъства по една случайно избрана буква от всеки вид
			(например ако генотипът на родителя е АаВВСс, възможните гамети са АВС, АВс, аВС, аВс)*/
			Random r = new Random();
			string g="";
			while(fgam.Count<fbr)
			{
				for (int i = 0; i < first.Length; i+=2)
				{
					g+=first[r.Next(i,i+2)];
				}
				if (!fgam.Contains(g))
				{
					fgam.Add(g);
				}
				g="";
			}
			fgam.Sort();
			fgam.Reverse();
			
			string sg="";
			while(sgam.Count<sbr)
			{
				for (int i = 0; i < second.Length; i+=2)
				{
					sg+=second[r.Next(i,i+2)];
				}
				if (!sgam.Contains(sg))
				{
					sgam.Add(sg);
				}
				sg="";
			}
			sgam.Sort();
			sgam.Reverse();
		}
		public void GetGenotypes(ref List <string> fgam, ref List <string> sgam)
		{
			/*Записване на гаметите като елементи от първия ред и съответно първата колона на двуизмерния масив.*/
			string [,] a = new string[sgam.Count+1,fgam.Count+1];
			a[0,0]=" ";
			for (int i = 1; i <= fgam.Count; i++)
			{
				a[0,i]=new String(' ',fgam[0].Length*4)+fgam[i-1];
			}
			
			for (int i = 1; i <= sgam.Count; i++)
			{
				a[i,0]=sgam[i-1];
			}
			
			/*Намиране на генотиповете на децата. Всеки от тях се състои от една гамета на единия родител и една гамета на другия родител,
			соритирани по букви (вместо АвСаВС е АаВвСС), както и низ от интервали за изравняване при самото визуализиране*/
			char[] b = new char[2]; //Временно записва буквите от един вид (АА, Аа, аа), за да се сортират първо главна, после малка. След което се нулира.
			string helper; //Временно приема стойността на поредния генотип на детето, за да не става объркване с много индекси.
			List <char> dvaAlela=new List<char>(); /*В него се натрупват поредните две букви от b, вече сортирани главна преди малка.
			След свършване на цикъла dvaAlela съдържа вече напълно сортиран целия пореден генотип на детето, който се записва отново в a[j,i], а dvaAlela се нулира, за да се започне записването на следващия генотип на дете*/
			for (int i = 1; i < a.GetLength(1); i++)
			{
			    for (int j = 1; j < a.GetLength(0); j++)
			    {
			    	a[j,i]=fgam[i-1]+sgam[j-1];
			    	helper=a[j,i].ToString();
			    	for (int n = 0; n < fgam[0].Length; n++)
			    	{
			    		b[0]=helper[n];
			    		b[1]=helper[n+fgam[0].Length];
			    		Array.Sort(b);
			    		dvaAlela.AddRange(b);
			    	}
			    	a[j,i]=new String(' ',fgam[0].Length*3)+string.Join("",dvaAlela);
			    	helper="";
			    	dvaAlela.Clear();
			    }
			}
			
			/*Извеждане на двуизмерния масив на екрана.
			Масивът съдържа: 1. На първата колона и първия ред (без а[0,0]) - гаметите на родителите;
			2. Всички останали елементи от масива са генотиповете на децата, получени от комбинирането на съответните гамети.*/
			for (int i = 0; i < a.GetLength(0); i++)
       		{
				for (int j = 0; j < a.GetLength(1); j++)
	            {
	                Console.Write(string.Format("{0} ", a[i, j]));
	            }
            	Console.Write(Environment.NewLine + Environment.NewLine);
        	}	
		}
		public void Print(ref List <string> fgam, ref List <string> sgam)
		{
			GetGametes(ref fgam, ref sgam);
			Console.WriteLine("");
			Console.WriteLine("P: {0} X {1}", first, second);
			Console.WriteLine("");
			Console.WriteLine("F1:");
			Console.WriteLine("");
			GetGenotypes(ref fgam, ref sgam);
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Enter first genotype of a parent: ");
			string a = Console.ReadLine();
			Console.Write("Enter second genotype of a parent: ");
			string b = Console.ReadLine();
			Hybrids h = new Hybrids(a,b);
			List <string> fgam = new List<string>();
			List <string> sgam = new List<string>();
			h.Print(ref fgam, ref sgam);
			
			Console.WriteLine("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}