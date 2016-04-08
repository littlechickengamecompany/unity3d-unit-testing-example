using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;

public class EnemySpawnerView : View, IEnemySpawner {

    public readonly Signal SpawnEnemySignal = new Signal();

    public void Spawn() {
        EnemyView enemy = GameObject.Instantiate<EnemyView>(Resources.Load<EnemyView>("Enemy"));

        enemy.transform.position = transform.position;
        enemy.transform.forward = transform.forward;
        enemy.Velocity = enemy.transform.forward * 2;
    }

    private void Update() {
        if(Random.value < 0.003) {
            SpawnEnemySignal.Dispatch();
        }
    }

}
