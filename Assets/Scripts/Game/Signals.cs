using strange.extensions.signal.impl;

public class TurretClickedSignal : Signal<ITurret>{ }
public class SpawnEnemySignal : Signal<EnemySpawnerView> { }
public class BulletHitSignal : Signal<IDestroyable> { }
