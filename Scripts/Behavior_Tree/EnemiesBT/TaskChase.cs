using Godot;
using System;

using BehaviorTree;
using enemystats;

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
		var delta = new Vector2((float)enemy_stats.delta * 50, (float)enemy_stats.delta * 50);
		Velocity = enemy.Position.DirectionTo(Target).Normalized();

		if (enemy.GlobalPosition.DistanceTo(Target) > 175f)
			enemy.Position += Velocity * delta;

		if (enemy.GlobalPosition.DistanceTo(Target) < 175f)
			enemy.Position += -Velocity * delta;
		//GD.Print($"player: {player.Position} | enemy: {enemy.Position} || velocity: {Velocity} || distance: {enemy.GlobalPosition.DistanceTo(Target)}");

		return NodeState.RUNNING;
	}
}
