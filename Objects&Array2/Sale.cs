using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Array2
{
	internal class Sale:IComparable
	{
		int invoiceNumber;
		double amount;
		double tax;

		public Sale()
		{
			invoiceNumber = 0;
			amount = 0;
			tax = 0;
		}
		public Sale(int invoiceNumber, double amount)
		{
			this.invoiceNumber = invoiceNumber;
			this.amount = amount;
			tax=	CalcTax(amount);
		}
		public int GetInvoice()
		{
			return invoiceNumber;
		}
		public void SetInvoice(int invoiceNumber)
		{
			this.invoiceNumber= invoiceNumber;
		}
		public void SetAmount(double amount)
		{
			this.amount = amount;
			tax =CalcTax(amount);
		}
		public double CalcTax(double amount)
		{
			double taxAmount;
			if(amount<=100)
			{
				taxAmount = amount * 0.15 ;
			}
			else
			{
				taxAmount = amount * 0.14;
			}

			return taxAmount;
		}
		public void DisplaySale()
		{
			Console.WriteLine("Inventory {0}: Amount {1:C} Tax owed {2:C}",invoiceNumber,amount,tax);
		}
		int IComparable.CompareTo(object obj)
		{
			int returnVal;
			Sale temp= (Sale)obj;	

			if(this.invoiceNumber>temp.invoiceNumber)
			{
				returnVal = 1;
			}
			else if(this.invoiceNumber<temp.invoiceNumber)
			{
				returnVal = -1;
			}
			else
			{
				returnVal = 0;
			}
			return returnVal;
		}
	}
}
