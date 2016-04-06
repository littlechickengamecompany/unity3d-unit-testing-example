using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

public class KillEnemyCommand : Command {

	[Inject]
    public EnemyView Enemy { get; set; }

    [Inject]
    public BulletView Bullet { get; set; }

    [Inject]
    public Score Score { get; set; }

    public override void Execute() {
        GameObject.Destroy(Enemy.gameObject);
        GameObject.Destroy(Bullet.gameObject);

        Score.AddScore(10);
    }

}
