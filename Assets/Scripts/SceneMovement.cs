using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

static public class SceneMovement{

	static public void openWithBackGround(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        SceneManager.LoadScene("BackGround", LoadSceneMode.Additive);
    }
}
