using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Objects_Classes
{
	internal class Player
	{
	    string name;
		public int number;
		public int goals;
		public int assists;

		public Player(string name, int number, int goals, int assists)
		{
			this.name = name;
			this.number = number;
			this.goals = goals;
			this.assists = assists;

			//when the object is constructed,the four values received in the parameter list is assigned to the relevant attributes
		}
		public Player()
		{
			name = "";
			number = 0;
			goals = 0;
			assists = 0;
		}
		public Player(string name,int number)
		{
			this.name = name;
			this.number = number;
			goals = 0;
			assists = 0;
		}
		public void SetName(string name)
		{
			this.name = name;
		}
		public string GetName()
		{
			return this.name;
		}
		public void DisplayPlayer()
		{
			WriteLine("Player details:");
			WriteLine("Player details: Name {0}, Jersey number {1}, Goals scored {2}, Assists {3}",name,number, goals, assists);
			WriteLine();
		}
	}
}
