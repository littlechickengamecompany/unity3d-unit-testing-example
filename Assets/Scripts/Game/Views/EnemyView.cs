using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class EnemyView : View {

    public Vector3 Velocity { get; internal set; }

	private void Update () {
        transform.localPosition += Velocity * Time.deltaTime;
	}
}
