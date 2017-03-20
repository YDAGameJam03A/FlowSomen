using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class GSFailed : GameState{

	
		
    public override void Execute()
    {
        Debug.Log("Failed");
		ref_gameManager.Gameover.isGame_Over = 1;
    }
}
