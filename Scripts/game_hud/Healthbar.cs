using Godot;
using playerstats;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public partial class Healthbar : TextureProgressBar
{
	Timer timer;


	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override async void _Process(double delta)
	{
		this.Value = player_stats.Health;
		this.MaxValue = player_stats.Max_Health;
		GetChild<Label>(0).Text = $"{this.Value} / {this.MaxValue}";

		if (player_stats.Health < player_stats.Max_Health)
		{
			
			player_stats.Health += player_stats.Health_regen;
		}

	}
}
