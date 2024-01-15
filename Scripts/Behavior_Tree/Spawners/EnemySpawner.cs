using Godot;
using System;

using BehaviorTree;
public partial class EnemySpawner : BehaviorTree.Tree
{
	[Export]
	private Node2D SpawnerNode;

	protected override BtNode SetupTree()
	{
		BtNode root = new TaskEnemySpawner(SpawnerNode);
		return root;
	}

}
