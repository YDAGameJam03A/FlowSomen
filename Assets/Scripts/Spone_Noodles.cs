using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spone_Noodles : MonoBehaviour
{

    public GameObject Noodles;

    private float time;         //n秒ごとに実行する


    void Start()
    {

        
    }

    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0.0)
        {
            time = 0.5f;
            Instantiate(Noodles, new Vector3(0, 3, 0), Quaternion.identity);

        }
    }
}
