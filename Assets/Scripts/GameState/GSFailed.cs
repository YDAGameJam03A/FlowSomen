using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class GSFailed : GameState{

	public GameOver Gameover;

	void Start()
	{
		Gameover = GameObject.Find ("canvas").GetComponent<GameOver> ();
	}

		
    public override void Execute()
    {
        Debug.Log("Failed");
		Gameover.isGame_Over = 1;
    }
}
