using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SCENESTATE
{
    COUNT,
    LOGO
}

class GSStartCount : GameState {
    float StartCount;
    float EndTime = 3.0f;
    bool atFirst = true;
    SCENESTATE sceneState = SCENESTATE.COUNT;
    public override void Execute()
    {
        Debug.Log("StartCount");
        switch (sceneState)
        {
            case SCENESTATE.COUNT:
                break;
            case SCENESTATE.LOGO:
                break;
        }
        
    }
}
