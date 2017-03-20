using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class GSInitilze : GameState{

    public override void Execute()
    {
        Debug.Log("Initilze");
        ref_gameManager.SetGameStates(GAMESTATE.STARTCOUNT);
    }
}
