using Godot;
using System;
using System.Threading.Tasks;

public partial class Exit_button : TextureButton
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override async void _Process(double delta)
	{
		if (this.ButtonPressed == true)
		{
			await Task.Delay(250);
			GetTree().Quit();
		}
	}


}
