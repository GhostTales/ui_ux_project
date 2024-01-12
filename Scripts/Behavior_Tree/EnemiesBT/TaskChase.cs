using Godot;
using System;

using BehaviorTree;

public partial class TaskChase : BtNode
{
	private Node2D enemy;
	private Node2D player;

	private const float speed = 50f;
	private Vector2 Target;
	private Vector2 Velocity;

	public TaskChase(Node2D enemy, Node2D player)
	{
		this.player = player;
		this.enemy = enemy;

	}

	public override NodeState Evaluate()
	{
		Target = player.GlobalPosition;
		Velocity = enemy.GlobalPosition.DirectionTo(Target) * new Vector2(0.05f, 0.05f);

		if (enemy.GlobalPosition.DistanceTo(Target) > 150f)
			enemy.Position += Velocity;

		if (enemy.GlobalPosition.DistanceTo(Target) < 125f)
			enemy.Position -= Velocity;
		




		//GD.Print($"player: {player.Position} | enemy: {enemy.Position} || velocity: {Velocity} || distance: {enemy.GlobalPosition.DistanceTo(Target)}");

		return NodeState.RUNNING;
	}
}
