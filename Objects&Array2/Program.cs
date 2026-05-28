using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Array2
{
	internal class Program
	{
		const int SIZE=5;
		static void Main(string[] args)
		{

			Sale[] saleList = new Sale[SIZE];
			int nrEl = 0;
			

			//Assuming we want to fill the list
	
				for (int x = 0; x < saleList.Length; x++)
				{
					AddSale(saleList, ref nrEl);
				}
		
			Console.WriteLine();
			Console.WriteLine("List of sales:");

			//display all objects in the list
		
				for (int x = 0; x < saleList.Length; x++)
				{
					saleList[x].DisplaySale();
				}
			Array.Sort(saleList);

			Sale seekInvoice = new Sale();
			Console.WriteLine();
			Console.WriteLine("Enter the inventory number of the sale that needs updating: ");
			int wanted=int.Parse(Console.ReadLine());

			seekInvoice.SetInvoice(wanted);

			int pos = Array.BinarySearch(saleList,seekInvoice);
			if (pos >= 0)
			{
				
				Console.Write("Enter the updated sales amount for the sale:");
				double amount = double.Parse(Console.ReadLine());
				saleList[pos].SetAmount(amount);
			}

			else
			{
				Console.WriteLine("This inventory number does not exist");
			}

			Array.Sort(saleList);
			Console.WriteLine() ;
			Console.WriteLine("List of sales,after the update:");

			for(int x=0;x< saleList.Length;x++) 
			{
				saleList[x].DisplaySale();
			}
			Console.ReadLine();
		}
		static void AddSale(Sale[] saleList,ref int nrEl)
		{
			Console.Write("Enter inventory number: ");
			int num=int.Parse(Console.ReadLine());

			Console.Write("Enter the amount: ");
			double amount=double.Parse(Console.ReadLine());

			saleList[nrEl]=new Sale(num,amount);
			nrEl++;

			Console.WriteLine();
		}
	}
}
