using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Classes2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ClassifiedAd Ad1 = new ClassifiedAd("Used Cars", 160);
			ClassifiedAd Ad2 = new ClassifiedAd("Appliances", 80);

			Console.WriteLine("First ad category: {0}",Ad1.GetCategory());
			Ad2.SetWords(100);

			Ad1.DisplayAd();
			Ad2.DisplayAd();

			Console.ReadLine();
		}
	}
}
