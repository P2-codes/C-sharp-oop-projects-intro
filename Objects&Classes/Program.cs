using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Objects_Classes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//decalaring objects
			Player player1 = new Player();

			Player player2=new Player("Jerry",3,2,2);

			Player player3=new Player("Leo",30);


			player2.SetName("Christiano"); //updating an attribute

			player1.DisplayPlayer();
			player2.DisplayPlayer();
			player3.DisplayPlayer();

			ReadLine();
		}
	}
}
