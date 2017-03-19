using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum SCENESTATE
{
    INITIALIZE,
    COUNT,
    LOGO
}

class GSStartCount : GameState {
    float StartCount;
    int PrevStartCount = 0;
    float EndTime = 3.0f;
    float sceneChangeInterval = 1.0f;
    bool atFirst = true;
    
    SCENESTATE sceneState = SCENESTATE.INITIALIZE;

    public override void Execute()
    {
        Debug.Log("StartCount");
        
        Debug.Log("time = " + StartCount);
        switch (sceneState)
        {
            case SCENESTATE.INITIALIZE:
                ref_gameManager.countDownTimer.SetActive(true);
                sceneState = SCENESTATE.COUNT;
                break;
            case SCENESTATE.COUNT:
                StartCount += Time.deltaTime;
                if (PrevStartCount != (int)(StartCount / 1.0f))
                {
                    PrevStartCount = (int)(StartCount / 1.0f);
                    ref_gameManager.TimeCountUI.text = ((int)EndTime - PrevStartCount).ToString();
                    if (StartCount >= EndTime)
                    {
                        StartCount = 0.0f;
                        ref_gameManager.TimeCountUI.text = "スタート！";
                        sceneState = SCENESTATE.LOGO;
                    }
                }
                break;
            case SCENESTATE.LOGO:
                StartCount += Time.deltaTime;
                if (StartCount >= sceneChangeInterval)
                {
                    ref_gameManager.countDownTimer.SetActive(false);
                    ref_gameManager.SetGameStates(GAMESTATE.INGAME);
                }
                break;
        }
        
    }
}
