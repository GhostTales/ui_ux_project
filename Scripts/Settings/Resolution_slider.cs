using Godot;
using System;
using System.Collections.Generic;

public partial class Resolution_slider : HSlider
{
	int Resolution { get; set; }
	List<string> Resolutions = new List<string>() { "640x480", "800x600", "1024x768", "1152x864", "1280x720", "1600x900", "1920x1080" };
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.MaxValue = Resolutions.Count - 1;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

		try
		{
			Resolution = (int)this.Value;
			GetNode<Label>("Label").Text = $"Resolution: {Resolutions[Resolution]}";
		}
		catch (System.Exception)
		{
			GD.Print($"Resolution Value out of range {Resolutions.Count} | Value = {this.Value}");
		}

	}
}
