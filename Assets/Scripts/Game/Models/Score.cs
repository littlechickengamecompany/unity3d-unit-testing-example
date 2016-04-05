using UnityEngine;
using System.Collections;

public class Score {

	public int Amount { get; private set; }

    public void AddScore(int amount) {
        Amount += amount;
    }
}
