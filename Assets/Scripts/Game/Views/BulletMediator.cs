using strange.extensions.mediation.impl;

public class BulletMediator : Mediator {
    
    [Inject]
    public BulletView View { get; set; }

    [Inject]
    public BulletHitSignal BulletHitSignal { get; set; }

    public override void OnRegister() {
        base.OnRegister();

        View.BulletHitEnemySignal.AddOnce(OnBulletHitEnemy);
    }

    private void OnBulletHitEnemy(EnemyView enemyView) {
        View.Destroy();
        BulletHitSignal.Dispatch(enemyView);
    }
}
