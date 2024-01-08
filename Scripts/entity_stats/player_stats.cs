using System.Collections.Generic;
using Godot;
using System;
using System.Threading.Tasks;

public partial class player_stats : Node
{
	public int Health { get; set; } = 10; // current health
	public int Max_Health { get; set; } = 100; // max health
	public int Health_regen { get; set; } = 2; // passive health regen
	public int Damage { get; set; } = 15; // damage per hit
	public int Crit_Chance { get; set; } = 10; // percentage 1 - 100
	public int Armour { get; set; } = 0; // damage reduction


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override async void _Process(double delta)
	{
		while (Health != Max_Health)
		{
			await Task.Delay(1000);
			Health += Health_regen;
		}
	}
}
