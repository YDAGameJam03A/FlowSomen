using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Button))]
public class Gameoverbutton : UIBehaviour
{
	　protected override void Start()
	　{
		　　base.Start();

		　　// Buttonクリック時、OnClickメソッドを呼び出す
		　　GetComponent<Button>().onClick.AddListener(OnClick);
		　}

	　void OnClick()
	　{
        // 「Stageserect」シーンに遷移する
        //SceneManager.LoadScene("Title");
        SceneMovement.openWithBackGround("Title");
	}
}