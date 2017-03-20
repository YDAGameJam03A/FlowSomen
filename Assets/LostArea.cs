using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostArea : MonoBehaviour {
    GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }


    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Somen")
        {
            gameManager.DecleaseLife();
            Destroy(collision.gameObject, 1.0f);
        }
    }
}
