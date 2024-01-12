using Godot;
using System;

using BehaviorTree;
using System.Threading.Tasks;
using playerstats;
public partial class TaskEnemySpawner : BtNode
{
	private PackedScene EnemyScene;
	private Node2D Spawner;
	private Node2D player;
	public TaskEnemySpawner(PackedScene scene, Node2D Spawner)
	{
		this.EnemyScene = scene;
		this.Spawner = Spawner;
		this.player = player_stats.Player_Id;
	}

	public override NodeState Evaluate()
	{
		var enemy = ResourceLoader.Load<PackedScene>("res://Scenes/Enemies/spitter_enemy.tscn").Instantiate();

		if (Spawner.GetChildCount() < 10)
			Spawner.AddChild(enemy);




		return NodeState.RUNNING;
	}

}
