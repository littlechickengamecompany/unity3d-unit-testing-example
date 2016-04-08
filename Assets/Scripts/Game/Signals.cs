using strange.extensions.signal.impl;

public class TurretClickedSignal : Signal<ITurret>{ }
public class SpawnEnemySignal : Signal<IEnemySpawner> { }
public class BulletHitSignal : Signal<IDestroyable> { }
