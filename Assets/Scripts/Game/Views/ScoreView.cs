using UnityEngine;
using strange.extensions.mediation.impl;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreView : View {
    private Text textComponent;

    protected override void Awake() {
        base.Awake();
        textComponent = GetComponent<Text>();
    }

    public void SetScore(int newScore) {
        textComponent.text = "SCORE: " + newScore;
    }
}
