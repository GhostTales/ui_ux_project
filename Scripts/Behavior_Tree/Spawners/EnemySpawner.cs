using Godot;
using System;

using BehaviorTree;
public partial class EnemySpawner : BehaviorTree.Tree
{
	[Export]
	PackedScene EnemyScene;
	protected override BtNode SetupTree()
	{
		BtNode root = new TaskEnemySpawner(this, EnemyScene);
		return root;
	}

}
