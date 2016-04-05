using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class ScoreMediator : Mediator {

    [Inject]
    public ScoreView View { get; set; }

    [Inject]
    public Score Score { get; set; }

    public void OnScoreAdded() {
        View.AddScore(10);
    }

}
