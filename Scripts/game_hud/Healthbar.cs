using Godot;
using System;
using System.Collections.Generic;

public partial class Healthbar : TextureProgressBar
{

	Node Player_stats;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Player_stats = GetNode<Node>("%Stats/player_stats");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		GetChild<Label>(0).Text = $"{this.Value} / {this.MaxValue}";
	}
}
