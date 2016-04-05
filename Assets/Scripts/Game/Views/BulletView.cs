using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;

public class BulletView : View {

    public readonly Signal<EnemyView> BulletHitEnemySignal = new Signal<EnemyView>();

    public Vector3 Velocity = Vector3.zero;

	private void Update () {
        transform.position += Velocity * Time.deltaTime;
	}

    private void OnCollisionEnter(Collision collision) {
        foreach (ContactPoint contact in collision.contacts) {
            if (contact.otherCollider.GetComponent<EnemyView>()) {
                BulletHitEnemySignal.Dispatch(contact.otherCollider.GetComponent<EnemyView>());
            }
        }
    }
}
