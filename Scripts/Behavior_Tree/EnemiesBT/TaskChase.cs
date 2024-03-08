using Godot;
using System;

using BehaviorTree;
using enemystats;
using playerstats;

public partial class TaskChase : BtNode
{
	private CharacterBody2D enemy;
	private Node2D player;

	int speed;

	public TaskChase(CharacterBody2D enemy, Node2D player, int speed)
	{
		this.player = player;
		this.enemy = enemy;
		this.speed = speed;

	}

	public override NodeState Evaluate()
	{
		Vector2 moveDirection = (player.Position - enemy.Position).Normalized();

		enemy.Velocity = moveDirection * speed * (1 + player_stats.delta);
		enemy.MoveAndSlide();

		return NodeState.RUNNING;
	}
}
