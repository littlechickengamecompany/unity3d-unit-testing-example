using UnityEngine;
using strange.extensions.command.impl;

public class SpawnEnemyCommand : Command {

    [Inject]
    public IEnemySpawner EnemySpawner { get; set; }

    public override void Execute() {
        EnemySpawner.Spawn();
    }

}
