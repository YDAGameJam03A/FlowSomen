using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class GameState : MonoBehaviour {
    GameManager ref_gameManager;

    public void SetGamemanager(GameManager t_ref_gameManager)
    {
        ref_gameManager = t_ref_gameManager;
    }

    abstract public void Execute();
}
