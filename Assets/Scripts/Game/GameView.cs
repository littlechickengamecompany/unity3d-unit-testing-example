using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;

public class GameView : ContextView {

	private void Awake() {
        context = new GameContext(this);
    }
}
