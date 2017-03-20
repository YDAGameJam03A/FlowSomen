using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

enum CLSCENESTATE
{
    INITIALIZE,
    LOGO,
    TERMINATED
};

class GSClear: GameState{
    CLSCENESTATE clearSceneState;

    public override void Execute()
    {

        Debug.Log("Clear");
        switch (clearSceneState)
        {
            case CLSCENESTATE.INITIALIZE:
                ref_gameManager.ClearUI.SetActive(true);
                clearSceneState = CLSCENESTATE.TERMINATED;
                break;
            case CLSCENESTATE.TERMINATED:
                DataKeeper.score = ref_gameManager.score;
                //SceneManager.LoadScene(/*リザルトシーン*/);
                Debug.Log("Terminated");
                break;
        }
    }
}
