using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomenFactory : MonoBehaviour {
    [SerializeField]
    GameManager gameManager;
    [SerializeField]
    GameObject[] spawnPoint;
    [SerializeField]
    GameObject somenPrefab;

    /*
        ソーメンの生成
    */
	public void CreateSomen()
    {
        Instantiate(somenPrefab,
                    spawnPoint[Random.Range(0, spawnPoint.Length - 1)].transform.position,
                    Quaternion.Euler(0, 0, 0));
    }
}
