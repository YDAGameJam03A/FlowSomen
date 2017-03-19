using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GAMEDIFFCULT{
    EASY = 0,
    NORMAL,
    HARD
};

public enum GAMESTATE
{
    INIT = 0,
    STARTCOUNT,
    INGAME,
    FAILED,
    CLEAR
};

public class GameManager : MonoBehaviour {

    GameDatas[] gamedataInstances = {
        new GDEasy(),new GDNormal(),new GDHard()
    };
    GameState[] gameStateInstances = {
        new GSInitilze(),
        new GSStartCount(),
        new GSInGame(),
        new GSFailed(),
        new GSClear()
    };

    int score = 0;
    int Life = 0;
    GameDatas gameData = new GameDatas();
    GAMESTATE gameState = GAMESTATE.INIT;

	// Use this for initialization
	void Start () {
		for(int i = 0; i < gameStateInstances.Length; i++)
        {
            gameStateInstances[i].SetGamemanager(this);
        }
	}
	
	// Update is called once per frame
	void Update () {
        gameStateInstances[(int)gameState].Execute();
	}
    /*
     ゲームデータのセッタ
     ゲームデータの初期化を行う
    */
    public void SetGameDatas(GAMEDIFFCULT diff)
    {
        gameData = gamedataInstances[(int)diff];
    }

    public void SetGameStates(GAMESTATE state)
    {
        gameState = state;
    }

    public void DebugLogGameData()
    {
        Debug.Log("typename = " + gameData.GetType());
    }

    public void DebugLogGameState()
    {
        Debug.Log("statename = " + gameStateInstances[(int)gameState].GetType());
    }
}
