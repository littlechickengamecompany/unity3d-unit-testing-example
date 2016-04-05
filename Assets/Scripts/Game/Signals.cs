using UnityEngine;
using System.Collections;
using strange.extensions.signal.impl;

public class TurretClickedSignal : Signal<TurretView>{ }
public class SpawnEnemySignal : Signal<EnemySpawnerView> { }
public class BulletHitSignal : Signal<BulletView, EnemyView> { }
