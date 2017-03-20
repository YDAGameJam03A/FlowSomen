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
        new GDEasy(),
        new GDNormal(),
        new GDHard()
    };
    GameState[] gameStateInstances = {
        new GSInitilze(),
        new GSStartCount(),
        new GSInGame(),
        new GSFailed(),
        new GSClear()
    };

    int Score = 0;
    public int score
    {
        get
        {
            return Score;
        }
        set
        {
            Score = score;
        }
    }
    int Life = 5;
    public int life
    {
        get
        {
            return Life;
        }
    }
    GameDatas gameData = new GDEasy();
    public GameDatas gameDatas
    {
        get
        {
            return gameData;
        }
    }
	GAMESTATE gameState = GAMESTATE.INGAME;

    SomenFactory somenFactory;
    public SomenFactory somenfactory
    {
        get
        {
            return somenFactory;
        }
    }
    //STATE.STARTCOUNTで使用するGameObject群
    public GameObject countDownTimer;
    public UnityEngine.UI.Text TimeCountUI;

    //STATE.CLEARで使用するGameObject群
    public GameObject ClearUI;

    // Use this for initialization
    void Start () {
		for(int i = 0; i < gameStateInstances.Length; i++)
        {
            gameStateInstances[i].SetGamemanager(this);
        }
        somenFactory = GameObject.FindGameObjectWithTag("SomenFactory").GetComponent<SomenFactory>();
        //countDownTimer = GameObject.FindGameObjectWithTag("CountDownTimer");
        //TimeCountUI = GameObject.FindGameObjectWithTag("TimeCountUI").GetComponent<UnityEngine.UI.Text>();
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

    public void DecleaseLife()
    {
        Life -= 1;
    }
}
