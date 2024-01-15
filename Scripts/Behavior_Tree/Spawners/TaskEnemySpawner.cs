using Godot;
using System;

using BehaviorTree;
using System.Threading.Tasks;
using playerstats;
using System.Threading;
public partial class TaskEnemySpawner : BtNode
{
	private PackedScene EnemyScene;
	private Node2D Spawner;
	private Node2D player;


	private static Random rnd = new Random();
	public TaskEnemySpawner(PackedScene scene, Node2D Spawner){
		this.EnemyScene = scene;
		this.Spawner = Spawner;
		this.player = player_stats.Player_Id;
	}

	public override NodeState Evaluate()
	{
		var enemy = ResourceLoader.Load<PackedScene>("res://Scenes/Enemies/spitter_enemy.tscn").Instantiate();
		
		
			(enemy as Node2D).Position = player.Position + new Vector2(250, 0).Rotated((float)rnd.Next(0, 62831) / 10000);
			if (Spawner.GetChildCount() < 100)
			{
				Spawner.AddChild(enemy);
				
			}
		

		return NodeState.RUNNING;
	}

}
