using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using System;

public class TurretMediator : Mediator {

    [Inject]
    public TurretView View { get; set; }

    [Inject]
    public TurretClickedSignal TurretClickedSignal { get; set; }

    public override void OnRegister() {
        base.OnRegister();

        View.TurretClickedSignal.AddListener(OnTurretClicked);
    }

    private void OnTurretClicked() {
        TurretClickedSignal.Dispatch(View);
    }
}
