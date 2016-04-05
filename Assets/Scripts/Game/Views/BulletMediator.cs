using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using System;

public class BulletMediator : Mediator {
    
    [Inject]
    public BulletView View { get; set; }

    [Inject]
    public BulletHitSignal BulletHitSignal { get; set; }

    public override void OnRegister() {
        base.OnRegister();

        View.BulletHitEnemySignal.AddListener(OnBulletHitEnemy);
    }

    private void OnBulletHitEnemy(EnemyView enemyView) {
        BulletHitSignal.Dispatch(View, enemyView);
    }
}
