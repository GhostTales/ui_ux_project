using Godot;
using playerstats;



public partial class player : CharacterBody2D
{
	private AnimatedSprite2D anim;
	
	public Vector2 current_dir;

	public override void _Ready()
	{
		anim = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		player_stats.Player_Id = this;
	}

	[Export]
	public int Speed { get; set; } = 100;

	public void GetInput()
	{
		Vector2 inputDirection = Input.GetVector("left", "right", "up", "down");
		Velocity = inputDirection * Speed * (1 + player_stats.delta);

		if (inputDirection != new Vector2(0, 0))
		{
			PlayAnimation(1);
			current_dir = inputDirection;
		}
		else
			PlayAnimation(0);

	}

	public override void _PhysicsProcess(double delta)
	{
		GetInput();
		MoveAndSlide(); 

		
		Move_Rigidbody(10);

	}

	public override void _Process(double delta)
	{
		player_stats.delta = (float)delta;
	}

	public void PlayAnimation(int movement)
	{
			if (current_dir == Vector2.Left || current_dir == Vector2.Right)
			{
				anim.FlipH = current_dir.X < 0;
				anim.Play("side_" + (movement == 1 ? "walk" : "idle"));
			}
			else if (current_dir == Vector2.Up)
				anim.Play("back_" + (movement == 1 ? "walk" : "idle"));

			else if (current_dir == Vector2.Down)
				anim.Play("front_" + (movement == 1 ? "walk" : "idle"));
	}

	public void Move_Rigidbody(float push_force)
	{
		for (int i = 0; i < GetSlideCollisionCount(); i++)
		{
			var c = GetSlideCollision(i);
			if (c.GetCollider() is RigidBody2D)
			{
				(c.GetCollider() as RigidBody2D).ApplyCentralImpulse(-c.GetNormal() * push_force);
			}
		}
	}
}