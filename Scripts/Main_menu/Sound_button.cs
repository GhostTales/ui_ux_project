using Godot;
using System;
using System.Threading.Tasks;

public partial class Sound_button : TextureButton
{
	int volume;
	HSlider sound;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		sound = GetNode<HSlider>("%Settings/Sound");
		volume = (int)sound.Value;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (sound.Value != 0)
			volume = (int)sound.Value;

		if (this.ButtonPressed)
		{
			sound.Value = 0;
			texture(true);
		}
		if (this.ButtonPressed == false && sound.Value == 0)
		{
			sound.Value = volume;
			texture(false);
		}
	}



	public void texture(bool swap)
	{
		Texture2D off_default = (Texture2D)GD.Load("res://pixilart/Prinbles_GUI_Asset_Silent (1.0.0)/asset/png/Buttons/Square-Medium/SoundOff/Default.png");
		Texture2D off_hover = (Texture2D)GD.Load("res://pixilart/Prinbles_GUI_Asset_Silent (1.0.0)/asset/png/Buttons/Square-Medium/SoundOff/Hover.png");
		Texture2D on_default = (Texture2D)GD.Load("res://pixilart/Prinbles_GUI_Asset_Silent (1.0.0)/asset/png/Buttons/Square-Medium/SoundOn/Default.png");
		Texture2D on_hover = (Texture2D)GD.Load("res://pixilart/Prinbles_GUI_Asset_Silent (1.0.0)/asset/png/Buttons/Square-Medium/SoundOn/Hover.png");

		if (swap == true)
		{
			this.TextureNormal = off_default;
			this.TextureHover = off_hover;
			this.TexturePressed = off_default;
			this.TextureFocused = off_hover;
		}
		else
		{
			this.TextureNormal = on_default;
			this.TextureHover = on_hover;
			this.TexturePressed = on_default;
			this.TextureFocused = on_hover;
		}

	}
}
