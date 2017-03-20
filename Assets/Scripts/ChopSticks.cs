using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopSticks : MonoBehaviour
{

    Animator _animator;

    private float time;         //n秒ごとに実行する

    // Use this for initialization
    void Start()
    {

        _animator = GetComponent<Animator>();
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            _animator.speed = 1;
        }

        time -= Time.deltaTime;
        if (time <= 0.0)
        {

            if (Input.GetMouseButtonDown(0))
            {
                _animator.Play("ChopSticks_L");
            }

            else        

            if (Input.GetMouseButtonUp(0))
            {
                _animator.speed = 0;
            }

            if (Input.GetMouseButtonDown(1))
            {
                _animator.Play("ChopSticks_R");
            }

            else   
                                   
            if (Input.GetMouseButtonUp(1))
            {
                _animator.speed = 0;
            }

        
            if (Input.GetMouseButton(0) && Input.GetMouseButton(1))
            {
                _animator.speed = 1;
                _animator.Play("ChopSticks_Up");
                time = 0.25f;
            }

        }
        
    }
}
