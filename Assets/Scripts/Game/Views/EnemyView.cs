using UnityEngine;
using strange.extensions.mediation.impl;
using DG.Tweening;

public class EnemyView : View, IDestroyable {

    public Vector3 Velocity { get; internal set; }

    [SerializeField]
    private GameObject VisualObject;

    public void Destroy() {
        Destroy(gameObject);
    }

    protected override void Start() {
        base.Start();

        VisualObject.transform.DOScaleZ(0.8f, 0.2f).SetLoops(40, LoopType.Yoyo);
        Destroy(gameObject, 9);
    }

    private void Update () {
        transform.localPosition += Velocity * Time.deltaTime;
    }
}
