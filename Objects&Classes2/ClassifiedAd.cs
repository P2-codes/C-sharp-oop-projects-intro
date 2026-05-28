using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Classes2
{
	internal class ClassifiedAd
	{
		string category;
		int numberWords;
		double price;

		public ClassifiedAd(string category, int numberWords)
		{
			this.category = category;
			this.numberWords = numberWords;
			price=this.numberWords*0.09;
		}
		public void SetCategory(string category)
		{
			this.category=category;
		}
		public string GetCategory() 
		{
			return category;
		}
		public void SetWords(int numberWords) 
		{
			this.numberWords=numberWords;
			price= this.numberWords*0.09;
		}
		public int GetWords() 
		{
			return numberWords; 
		}
		public double GetPrice()
		{
			return price;
		}
		public void DisplayAd()
		{
			Console.WriteLine("Category: {0}, Number of Words: {1}, Price: {2:C}",category,numberWords,price);
		}
	}
}
