using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;
using strange.extensions.command.api;
using strange.extensions.command.impl;

public class GameContext : MVCSContext {

	public GameContext(GameView gameView) : base(gameView) {

    }

    protected override void mapBindings() {
        base.mapBindings();

        injectionBinder.Bind<Score>().To<Score>().ToSingleton();

        commandBinder.Bind<TurretClickedSignal>().To<FireTurretCommand>();
        commandBinder.Bind<SpawnEnemySignal>().To<SpawnEnemyCommand>();
        commandBinder.Bind<BulletHitSignal>().To<KillEnemyCommand>();

        mediationBinder.Bind<TurretView>().To<TurretMediator>();
        mediationBinder.Bind<BulletView>().To<BulletMediator>();
        mediationBinder.Bind<EnemySpawnerView>().To<EnemySpawnerMediator>();
        mediationBinder.Bind<ScoreView>().To<ScoreMediator>();
    }

    protected override void addCoreComponents() {
        base.addCoreComponents();
        injectionBinder.Unbind<ICommandBinder>();
        injectionBinder.Bind<ICommandBinder>().To<SignalCommandBinder>().ToSingleton();
    }
}
