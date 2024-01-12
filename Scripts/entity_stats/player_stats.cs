using System;
using Godot;

namespace playerstats
{
	public static class player_stats
	{
		public static Node2D Player_Id { get; set; }
		public static int Health { get; set; } = 10; // current health
		public static int Max_Health { get; set; } = 100; // max health
		public static int Health_Regen { get; set; } = 2; // passive health regen
		public static int Experience { get; set; } = 0; // experience is self explanatory
		public static int Damage { get; set; } = 15; // damage per hit
		public static int Crit_Chance { get; set; } = 10; // percentage 1 - 100
		public static int Armour { get; set; } = 0; // damage reduction
	}
}