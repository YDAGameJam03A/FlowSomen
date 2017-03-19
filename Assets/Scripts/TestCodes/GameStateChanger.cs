using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateChanger : MonoBehaviour {
    [SerializeField]
    GameManager ref_gameManager;
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ref_gameManager.SetGameStates(GAMESTATE.INIT);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ref_gameManager.SetGameStates(GAMESTATE.STARTCOUNT);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ref_gameManager.SetGameStates(GAMESTATE.INGAME);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ref_gameManager.SetGameStates(GAMESTATE.FAILED);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            ref_gameManager.SetGameStates(GAMESTATE.CLEAR);
        }

    }
}
