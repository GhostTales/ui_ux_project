using Godot;
using System;

public partial class Settings_button : TextureButton
{
	Node2D settings;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		settings = GetNode<Node2D>($"%Settings");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (this.ButtonPressed)
			settings.Visible = true;
		else settings.Visible = false;
	}
}
