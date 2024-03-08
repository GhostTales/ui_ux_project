using BehaviorTree;
using Godot;
using System;

public partial class TaskChaseDist : BtNode
{
	int range;
	Node2D enemy;
	Node2D player;
	public TaskChaseDist(Node2D enemy, Node2D player, int range)
	{
		this.player = player;
		this.enemy = enemy;
		this.range = range;
	}

	public override NodeState Evaluate()
	{
		if (enemy.Position.DistanceTo(player.Position) > range)
			return NodeState.SUCCESS;

		return NodeState.FAILURE;
	}
}
