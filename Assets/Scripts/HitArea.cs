using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitArea : MonoBehaviour {
    Noodles noodles;
    ChopSticks chopSticks;
    private void Start()
    {
        chopSticks = GameObject.Find("ChopSticks").GetComponent<ChopSticks>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Somen")
        {
            noodles = other.gameObject.GetComponent<Noodles>();
            
            
        }
    }

}
