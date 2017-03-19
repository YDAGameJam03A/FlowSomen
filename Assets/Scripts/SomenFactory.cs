using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomenFactory : MonoBehaviour {
    GameManager gameManager;
    [SerializeField]
    GameObject[] spawnPoint;
    float[] rany = { 88.0f,92.0f};
    [SerializeField]
    GameObject somenPrefab;
    GameObject t_somen;
    int ran;
    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    /*
        ソーメンの生成
    */
    public void CreateSomen()
    {
        ran = Random.Range(0, rany.Length);
        t_somen = Instantiate(somenPrefab,
                    spawnPoint[Random.Range(0, spawnPoint.Length)].transform.position,
                    Quaternion.Euler(somenPrefab.transform.rotation.x,
                                     rany[ran],
                                     74));

        Debug.Log("prefab z = " + somenPrefab.transform.rotation.z);
    }
}
