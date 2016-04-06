using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;
using DG.Tweening;
using System;

public class TurretView : View, ITurret {

    public readonly Signal TurretClickedSignal = new Signal();

    public void Fire() {
        BulletView bullet = GameObject.Instantiate<BulletView>(Resources.Load<BulletView>("Bullet"));
        bullet.transform.SetParent(transform);
        bullet.transform.position = transform.position;
        bullet.Velocity = transform.forward * 7;
    }

    private void OnMouseDown() {
        transform.DOScaleY(0.8f, 0.05f).SetLoops(2, LoopType.Yoyo);
        TurretClickedSignal.Dispatch();
    }
}
