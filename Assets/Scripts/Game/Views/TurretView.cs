using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;
using DG.Tweening;

public class TurretView : View {

    public readonly Signal TurretClickedSignal = new Signal();

    private void OnMouseDown() {
        transform.DOScaleY(0.8f, 0.05f).SetLoops(2, LoopType.Yoyo);
        TurretClickedSignal.Dispatch();
    }
}
