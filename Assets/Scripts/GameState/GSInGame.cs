using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class GSInGame : GameState{

    float spawnTimer = 0.0f;
    public override void Execute()
    {
        Debug.Log("InGame");

        spawnTimer += Time.deltaTime;
        if (spawnTimer >= ref_gameManager.gameDatas.spawnlag)
        {
            ref_gameManager.somenfactory.CreateSomen();
            ref_gameManager.gameDatas.noodlenum -= 1;
            spawnTimer = 0.0f;
        }
    }
}
