using System;
using Godot;

namespace playerstats
{
	public static class player_stats
	{
		public static Node2D Player_Id;
		public static int Health = 10; // current health
		public static int Max_Health = 100; // max health
		public static int Health_Regen = 2; // passive health regen
		public static int Experience = 0; // experience is self explanatory
		public static int Damage = 15; // damage per hit
		public static int Crit_Chance = 10; // percentage 1 - 100
		public static int Armour = 0; // damage reduction
		public static float delta;
	}
}