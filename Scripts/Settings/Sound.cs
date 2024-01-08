using Godot;
using System;

public partial class Sound : HSlider
{
	int sound;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		sound = (int)this.Value;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		sound = (int)this.Value;
		GetNode<Label>("Label").Text = $"Volume: {sound.ToString()}%";
	}
}
