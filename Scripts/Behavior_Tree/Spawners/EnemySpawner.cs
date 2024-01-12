using Godot;
using System;

using BehaviorTree;
public partial class EnemySpawner : BehaviorTree.Tree
{
	[Export]
	private PackedScene EnemyScene;
	[Export]
	private Node2D SpawnerNode;

	protected override BtNode SetupTree()
	{
		BtNode root = new TaskEnemySpawner(EnemyScene, SpawnerNode);
		return root;
	}


}
