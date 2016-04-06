using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class ScoreMediator : Mediator {

    [Inject]
    public ScoreView View { get; set; }

    [Inject]
    public Score Score { get; set; }

    public override void OnRegister() {
        base.OnRegister();
        Score.ScoreChanged.AddListener(OnScoreChanged);
    }

    public override void OnRemove() {
        base.OnRemove();
        Score.ScoreChanged.RemoveListener(OnScoreChanged);
    }

    public void OnScoreChanged() {
        View.SetScore(Score.Amount);
    }

}
