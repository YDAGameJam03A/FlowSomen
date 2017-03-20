using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestDropDown : MonoBehaviour {
    [SerializeField]
    Dropdown LinkDropDown;
    [SerializeField]
    GameManager gameManager;
    [SerializeField]
    GameObject testGameStarter;

    public void OnPress()
    {
        gameManager.SetGameDatas((GAMEDIFFCULT)LinkDropDown.value);
        gameManager.SetGameStates(GAMESTATE.STARTCOUNT);
        testGameStarter.SetActive(false);
    }
}
