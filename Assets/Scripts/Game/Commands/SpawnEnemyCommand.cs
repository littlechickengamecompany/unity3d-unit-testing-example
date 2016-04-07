using UnityEngine;
using strange.extensions.command.impl;

public class SpawnEnemyCommand : Command {

    [Inject]
    public EnemySpawnerView EnemySpawnerView { get; set; }

    public override void Execute() {
        EnemyView enemy = GameObject.Instantiate<EnemyView>(Resources.Load<EnemyView>("Enemy"));

        enemy.transform.position = EnemySpawnerView.transform.position;
        enemy.transform.forward = EnemySpawnerView.transform.forward;
        enemy.Velocity = enemy.transform.forward * 2;
    }

}
