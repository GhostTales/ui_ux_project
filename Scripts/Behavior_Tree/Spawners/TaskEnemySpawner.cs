using Godot;
using System;

using BehaviorTree;
using System.Threading.Tasks;
using playerstats;
using System.Threading;
using enemystats;
public partial class TaskEnemySpawner : BtNode
{
	private PackedScene EnemyScene;
	private Node2D Spawner;
	private Node2D player;
	private CollisionShape2D collision;
	private CircleShape2D circle = new CircleShape2D();
	private static Random rnd = new Random();
	public TaskEnemySpawner(Node2D Spawner)
	{
		this.EnemyScene = GD.Load<PackedScene>("res://Scenes/Enemies/spitter_enemy.tscn");
		this.Spawner = Spawner;
		this.player = player_stats.Player_Id;

	}

	public override NodeState Evaluate()
	{

		if (Spawner.GetChildCount() < 500 && Engine.GetFramesPerSecond() >= 30)
		{
			var enemy = EnemyScene.Instantiate();
			(enemy as Node2D).Position = player.Position + new Vector2(500, 0).Rotated((float)rnd.Next(0, 62831) / 10000);

			Spawner.AddChild(enemy);

			enemy_stats.Count = Spawner.GetChildCount();
		}


		return NodeState.RUNNING;
	}

}
