using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    public int isGame_Over;

	// Use this for initialization
	void Start () {

        var obj = transform.Find("Gameover").gameObject;
        obj.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        var obj = transform.Find("Gameover").gameObject;
        if (isGame_Over == 1)
        {
            obj.SetActive(true);
            isGame_Over = 0;
        }
	}
}
