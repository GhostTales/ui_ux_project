using Godot;
using System;

using BehaviorTree;
using System.Collections.Generic;
using playerstats;

public partial class SpitterEnemyBT : BehaviorTree.Tree
{
	[Export]
	CharacterBody2D EnemyNode;
	Node2D PlayerNode = player_stats.Player_Id;
	
	protected override BtNode SetupTree()
	{
		
		BtNode root = new Sequence(new List<BtNode>
					{
						new TaskChaseDist(EnemyNode, PlayerNode, 175),
						new TaskChase(EnemyNode, PlayerNode, 75)
					});
		return root;

	}
}