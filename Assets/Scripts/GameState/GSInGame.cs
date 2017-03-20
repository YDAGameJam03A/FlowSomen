using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class GSInGame : GameState{

    float spawnTimer = 0.0f;
    bool seplayed = false;
    public override void Execute()
    {
        Debug.Log("InGame");
        //ライフがなくなった時、状態をFAILEDにし、Executeを終了
        if (ref_gameManager.life <= 0)
        {
            ref_gameManager.SetGameStates(GAMESTATE.FAILED);
            return;
        }
        spawnTimer += Time.deltaTime;   //時間カウントを行う
        //スポーン時間になった場合、ソーメンをスポーンさせる
        if (spawnTimer >= ref_gameManager.gameDatas.spawnlag - 1.0f)
        {
            if (seplayed == false)
            {
                ref_gameManager.se_noodleComing.Play();
                seplayed = true;
            }
            if (spawnTimer >= ref_gameManager.gameDatas.spawnlag)
            {
                ref_gameManager.somenfactory.CreateSomen();
                ref_gameManager.gameDatas.noodlenum -= 1;
                spawnTimer = 0.0f;
                seplayed = false;
                

            }
        }
        
    }
}
