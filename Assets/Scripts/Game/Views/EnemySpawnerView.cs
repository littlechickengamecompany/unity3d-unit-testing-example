using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;

public class EnemySpawnerView : View {

    public readonly Signal SpawnEnemySignal = new Signal();

    private void Update() {
        if(Random.value < 0.003) {
            SpawnEnemySignal.Dispatch();
        }
    }

}
