using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestDropDown : MonoBehaviour {
    [SerializeField]
    Dropdown LinkDropDown;
    [SerializeField]
    GameManager gameManager;

    public void OnPress()
    {
        gameManager.SetGameDatas((GAMEDIFFCULT)LinkDropDown.value);
    }
}
