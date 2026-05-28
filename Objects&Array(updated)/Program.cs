using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Array_updated_
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Declaring the array using class(for manipulation)
			ClassifiedAd[] adList = new ClassifiedAd[5];
			int nrEl = 0; //initially no elements in the list

			for(int x=0;x<adList.Length;x++)
			{
				AddClassifiedAd(adList,ref nrEl);
			}
			Console.WriteLine();
			Console.WriteLine("List of advertisements:");
			for(int x=0;x<nrEl;x++)
			{
				adList[x].DisplayAd();
			}
			
			Console.ReadLine();
		}
		static void AddClassifiedAd(ClassifiedAd[] adList,ref int nrEl)
		{
			Console.Write("Enter the category for the advertisement: ");
			string cat=Console.ReadLine();

			Console.Write("Enter the number of words in the advertisement: ");
			int words=int.Parse(Console.ReadLine());

			Console.Write("Does this customer have a different rate: (Y/N): ");
			char response=char.Parse(Console.ReadLine());

			if(response=='Y'||response=='y')
			{
				Console.Write("Enter the rate for this customer "); 
				double rate=double.Parse(Console.ReadLine());

				adList[nrEl]=new ClassifiedAd(cat,words,rate);
				nrEl++;
			}
			else
			{
				adList[nrEl]=new ClassifiedAd(cat,words);
				nrEl++;
			}
			Console.WriteLine();
		}
	}
}
