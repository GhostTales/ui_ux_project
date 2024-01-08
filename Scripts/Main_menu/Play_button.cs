using Godot;
using System;
using System.Threading.Tasks;

public partial class Play_button : TextureButton
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override async void _Process(double delta)
	{
		if (this.ButtonPressed)
		{
			await Task.Delay(500);
			GetTree().ChangeSceneToFile("res://Scenes/main_game.tscn");
		}
	}
}
