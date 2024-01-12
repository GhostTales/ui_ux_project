using Godot;
using System;

using BehaviorTree;
using playerstats;

public partial class SpitterEnemyBT : BehaviorTree.Tree
{
	[Export]
	Node2D EnemyNode;
	Node2D PlayerNode;


	protected override BtNode SetupTree()
	{
		PlayerNode = player_stats.Player_Id;
		//GD.Print($"{PlayerNode} || {EnemyNode}");

		BtNode root = new TaskChase(EnemyNode, PlayerNode);
		return root;
	}
}