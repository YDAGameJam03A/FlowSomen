using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noodles : MonoBehaviour {

    public float tx = 0f;           //x移動
    public float ty = 2f;           //y移動
    public float tz = 0f;           //z移動

    public float ry = 90;           //向き  88:右レーン 
                                    //      92:左レーン
    

    void Start () {
        

        //transform.rotation = Quaternion.Euler(0, ry, 74);
    }
	
	void Update () {
        
        //移動
        transform.Translate(tx * Time.deltaTime, -ty * Time.deltaTime, tz * Time.deltaTime);

    }
}
