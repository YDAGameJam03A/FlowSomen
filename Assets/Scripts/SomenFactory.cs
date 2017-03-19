using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomenFactory : MonoBehaviour {
    [SerializeField]
    GameManager gameManager;
    [SerializeField]
    GameObject[] spawnPoint;
    float[] rany = { 88.0f,92.0f};
    [SerializeField]
    GameObject somenPrefab;
    int ran;
    /*
        ソーメンの生成
    */
	public void CreateSomen()
    {
        ran = Random.Range(0, rany.Length);
        Instantiate(somenPrefab,
                    spawnPoint[Random.Range(0, spawnPoint.Length)].transform.position,
                    Quaternion.Euler(somenPrefab.transform.rotation.x,
                                     rany[ran],
                                     somenPrefab.transform.rotation.z));
    }
}
