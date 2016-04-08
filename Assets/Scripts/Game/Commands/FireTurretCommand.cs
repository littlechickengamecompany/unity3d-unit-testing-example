using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

public class FireTurretCommand : Command {

    [Inject]
	public ITurret Turret { get; set; }

    public override void Execute() {
        Turret.Fire();
    }
}
