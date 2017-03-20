using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeUI : MonoBehaviour {

    Text UIText;

    private void Start()
    {
        UIText = gameObject.GetComponent<Text>();
    }

    public void ChangeLifeUIText(int tlife)
    {
        UIText.text = tlife.ToString();
    }
}
