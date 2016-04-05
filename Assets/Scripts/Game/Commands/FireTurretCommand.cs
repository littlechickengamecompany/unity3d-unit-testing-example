using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

public class FireTurretCommand : Command {

    [Inject]
	public TurretView TurrentView { get; set; }

    public override void Execute() {
        BulletView bullet = GameObject.Instantiate<BulletView>(Resources.Load<BulletView>("Bullet"));

        bullet.transform.SetParent(TurrentView.transform);
        bullet.transform.position = TurrentView.transform.position;
        bullet.Velocity = TurrentView.transform.forward * 7;
    }
}
