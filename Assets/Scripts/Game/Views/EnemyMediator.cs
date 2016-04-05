using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class EnemyMediator : Mediator {

    [Inject]
    public EnemyView View { get; set; }

    public override void OnRegister() {
        base.OnRegister();
    }

}
