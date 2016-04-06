using UnityEngine;
using System.Collections;
using strange.extensions.signal.impl;

public class Score {

	public int Amount { get; private set; }
    public readonly Signal ScoreChanged = new Signal();

    public void AddScore(int amount) {
        Amount += amount;
        ScoreChanged.Dispatch();
    }
}
