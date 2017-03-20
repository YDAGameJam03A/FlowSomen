using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostArea : MonoBehaviour {
    GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Somen")
        {
            Destroy(collision.gameObject, 1.0f);
        }
    }
}
