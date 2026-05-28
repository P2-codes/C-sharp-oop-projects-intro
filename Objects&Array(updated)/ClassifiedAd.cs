using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Array_updated_
{
	internal class ClassifiedAd
	{
		string category;
		int numberWords;
		double price;
		readonly double rate = 0.09;

		public ClassifiedAd(string category, int numberWords)
		{
			this.category = category;
			this.numberWords = numberWords;
			price = this.numberWords * rate;
		}
		public ClassifiedAd(string category,int numberWords,double rate) 
		{ 
			//constructor with different rate specified in parameters
			this.category=category;
			this.numberWords = numberWords;
			this.rate = rate;
			price=this.numberWords*this.rate;
		}

		public void SetCategory(string category)
		{
			this.category = category;
		}
		public string GetCategory()
		{
			return category;
		}
		public void SetWords(int numberWords)
		{
			this.numberWords = numberWords;
			price = this.numberWords * 0.09;
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
			Console.WriteLine("Category: {0}, Number of Words: {1}@rate:{2:C}, Price: {3:C}", category, numberWords,rate, price);
		}
	}
}
