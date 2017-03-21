using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopSticks : MonoBehaviour
{

    Animator _animator;
    HitArea hitArea;
    bool isRight;

    private float time;         //n秒ごとに実行する

    // Use this for initialization
    void Start()
    {
        //get Components
        hitArea = GameObject.Find("HitArea").GetComponent<HitArea>();
        _animator = GetComponent<Animator>();
        //コンポーネント関連初期化処理
        hitArea.enabled = false;
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            hitArea.enabled = true;
            _animator.speed = 1;
        }

        time -= Time.deltaTime;
        if (time <= 0.0)
        {

            if (Input.GetMouseButtonDown(0))
            {
                isRight = false;
                PlayAnimation("ChopSticks_L");
                
            }

            else        

            if (Input.GetMouseButtonUp(0))
            {

                //_animator.speed = -1;
                //_animator.StartPlayback();
                _animator.SetFloat("Speed", -1.0f); //アニメーションを継続して逆再生
                hitArea.enabled = false;
            }

            if (Input.GetMouseButtonDown(1))
            {
                isRight = true;
                PlayAnimation("ChopSticks_R");
            }

            else   
                                   
            if (Input.GetMouseButtonUp(1))
            {
                //_animator.StartPlayback();
                //_animator.speed = -1;
                _animator.SetFloat("Speed", -1.0f);
                hitArea.enabled = false;
            }

        
            if (Input.GetMouseButton(0) && Input.GetMouseButton(1))
            {
                
                PlayAnimation("ChopSticks_Up");
                time = 0.25f;
                hitArea.enabled = false;
            }

        }
        
    }

    void PlayAnimation(string stateName) 
    {
        _animator.SetFloat("Speed",1.0f);
        _animator.Play(stateName);
    }
}
