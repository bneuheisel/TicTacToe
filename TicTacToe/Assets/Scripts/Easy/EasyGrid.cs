using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EasyGrid : MonoBehaviour
{
    public Button button;
    public Text buttonText;
    //public string playerSide;

    private EasyAI gameController1;

    public void SetGameController1Reference(EasyAI controller1)
    {
        gameController1 = controller1;
    }
    public void SetSpace()
    {
        buttonText.text = gameController1.GetPlayerSide();
        button.interactable = false;
        gameController1.EndTurn();
    }
}
