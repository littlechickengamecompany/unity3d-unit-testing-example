using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using DG.Tweening;

public class EnemyView : View {

    public Vector3 Velocity { get; internal set; }

    protected override void Start() {
        base.Start();

        transform.DOScaleZ(1.8f, 0.2f).SetLoops(40, LoopType.Yoyo);
        Destroy(gameObject, 9);
    }

    private void Update () {
        transform.localPosition += Velocity * Time.deltaTime;
    }
}
