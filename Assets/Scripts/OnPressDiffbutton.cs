using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnPressDiffbutton : MonoBehaviour {
    [SerializeField]
    int diff;
    public void OnPress()
    {
        DataKeeper.gamediffcult = (GAMEDIFFCULT)diff;
        DataKeeper.gamestate = GAMESTATE.INIT;
        SceneManager.LoadScene("MainGame");
    }
}
