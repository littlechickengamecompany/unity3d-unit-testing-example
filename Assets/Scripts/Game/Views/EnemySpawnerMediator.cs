﻿using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using System;

public class EnemySpawnerMediator : Mediator {

    [Inject]
    public SpawnEnemySignal SpawnEnemySignal { get; set; }

    [Inject]
    public EnemySpawnerView View { get; set; }

    public override void OnRegister() {
        base.OnRegister();

        View.SpawnEnemySignal.AddListener(OnSpawnEnemy);
    }

    private void OnSpawnEnemy() {
        SpawnEnemySignal.Dispatch(View);
    }
}
