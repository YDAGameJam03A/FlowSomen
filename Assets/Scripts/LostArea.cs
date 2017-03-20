using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostArea : MonoBehaviour {
    GameManager gameManager;
    Noodles noodle;
    Collider PrevCollider;
    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }


    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Somen")
        {
            PrevCollider = collision;
            noodle = collision.gameObject.GetComponent<Noodles>();
            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (PrevCollider == other)
        {
            if (noodle.iscatching == false)
            {
                gameManager.DecleaseLife();
                Destroy(other.gameObject, 2.0f);
                PrevCollider = null;
            }
        }
        
    }
}
