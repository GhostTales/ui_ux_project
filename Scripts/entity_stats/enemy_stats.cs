using System;

namespace enemystats
{
	public static class enemy_stats
	{
		public static int Health { get; set; } = 100; // current health
		public static int Max_Health { get; set; } = 100; // max health
		public static int Health_regen { get; set; } = 2; // passive health regen
		public static int Damage { get; set; } = 15; // damage per hit
		public static int Armour { get; set; } = 0; // damage reduction
		public static int Count { get; set; } // amount of enemies
		public static double delta { get; set; } // delta for enemies
	}
}