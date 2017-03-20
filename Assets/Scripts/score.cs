using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour {
    Text text2;
	// Use this for initialization
	void Start () {
        text2 = GetComponentInChildren<Text>();
        text2.text = DataKeeper.score.ToString()+"kg";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
