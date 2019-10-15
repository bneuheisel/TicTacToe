using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
[System.Serializable]
public class Player1
{
    public Image panel;
    public Text text;
    public Button button;
}
[System.Serializable]
public class PlayerColor1
{
    public Color panelColor;
    public Color textColor;
}
*/
public class HardAI : MonoBehaviour
{
    public Text[] buttonList;
    public GameObject gameOverPanel;
    public Text gameOverText;
    private string playerSide;
    private string computerSide;
    private int moveCount;
    public GameObject restartButton;
    public GameObject startInfo;

    public Player playerX;
    public Player playerO;
    public PlayerColor activePlayerColor;
    public PlayerColor inactivePlayerColor;

    public bool playerMove;
    public float delay;
    private int value;

    //private GridSpace1 gSpace;

    public enum State { Null, X, O };

    void Awake()
    {
        SetGameController1ReferenceOnButtons();
        gameOverPanel.SetActive(false);
        moveCount = 0;
        restartButton.SetActive(false);
        playerMove = true;
    }

    public void Update()
    {
        if (playerMove == false)
        {
            delay += delay * Time.deltaTime;
            if (delay >= 100)
            {
                /*value = Random.Range(0, 8);
                if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                {
                    buttonList[value].text = GetComputerSide();
                    buttonList[value].GetComponentInParent<Button>().interactable = false;
                    EndTurn();
                }*/
                if(buttonList[0].text == playerSide && buttonList[1].text == playerSide)
                {
                    value = 2;
                    if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                    {
                        buttonList[value].text = GetComputerSide();
                        buttonList[value].GetComponentInParent<Button>().interactable = false;
                        EndTurn();
                    }
                    else
                    {
                        value = Random.Range(0, 8);
                        if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                        {
                            buttonList[value].text = GetComputerSide();
                            buttonList[value].GetComponentInParent<Button>().interactable = false;
                            EndTurn();
                        }
                    }
                    
                }
                else if (buttonList[2].text == playerSide && buttonList[1].text == playerSide)
                {
                    value = 0;
                    if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                    {
                        buttonList[value].text = GetComputerSide();
                        buttonList[value].GetComponentInParent<Button>().interactable = false;
                        EndTurn();
                    }
                    else
                    {
                        value = Random.Range(0, 8);
                        if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                        {
                            buttonList[value].text = GetComputerSide();
                            buttonList[value].GetComponentInParent<Button>().interactable = false;
                            EndTurn();
                        }
                    }

                }
                else if (buttonList[3].text == playerSide && buttonList[4].text == playerSide)
                {
                    value = 5;
                    if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                    {
                        buttonList[value].text = GetComputerSide();
                        buttonList[value].GetComponentInParent<Button>().interactable = false;
                        EndTurn();
                    }
                    else
                    {
                        value = Random.Range(0, 8);
                        if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                        {
                            buttonList[value].text = GetComputerSide();
                            buttonList[value].GetComponentInParent<Button>().interactable = false;
                            EndTurn();
                        }
                    }

                }
                else if (buttonList[5].text == playerSide && buttonList[4].text == playerSide)
                {
                    value = 3;
                    if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                    {
                        buttonList[value].text = GetComputerSide();
                        buttonList[value].GetComponentInParent<Button>().interactable = false;
                        EndTurn();
                    }
                    else
                    {
                        value = Random.Range(0, 8);
                        if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                        {
                            buttonList[value].text = GetComputerSide();
                            buttonList[value].GetComponentInParent<Button>().interactable = false;
                            EndTurn();
                        }
                    }

                }
                else if (buttonList[6].text == playerSide && buttonList[7].text == playerSide)
                {
                    value = 8;
                    if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                    {
                        buttonList[value].text = GetComputerSide();
                        buttonList[value].GetComponentInParent<Button>().interactable = false;
                        EndTurn();
                    }
                    else
                    {
                        value = Random.Range(0, 8);
                        if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                        {
                            buttonList[value].text = GetComputerSide();
                            buttonList[value].GetComponentInParent<Button>().interactable = false;
                            EndTurn();
                        }
                    }

                }
                else if (buttonList[8].text == playerSide && buttonList[7].text == playerSide)
                {
                    value = 6;
                    if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                    {
                        buttonList[value].text = GetComputerSide();
                        buttonList[value].GetComponentInParent<Button>().interactable = false;
                        EndTurn();
                    }
                    else
                    {
                        value = Random.Range(0, 8);
                        if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                        {
                            buttonList[value].text = GetComputerSide();
                            buttonList[value].GetComponentInParent<Button>().interactable = false;
                            EndTurn();
                        }
                    }

                }
                else if (buttonList[0].text == playerSide && buttonList[3].text == playerSide)
                {
                    value = 6;
                    if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                    {
                        buttonList[value].text = GetComputerSide();
                        buttonList[value].GetComponentInParent<Button>().interactable = false;
                        EndTurn();
                    }
                    else
                    {
                        value = Random.Range(0, 8);
                        if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                        {
                            buttonList[value].text = GetComputerSide();
                            buttonList[value].GetComponentInParent<Button>().interactable = false;
                            EndTurn();
                        }
                    }

                }
                else if (buttonList[6].text == playerSide && buttonList[3].text == playerSide)
                {
                    value = 0;
                    if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                    {
                        buttonList[value].text = GetComputerSide();
                        buttonList[value].GetComponentInParent<Button>().interactable = false;
                        EndTurn();
                    }
                    else
                    {
                        value = Random.Range(0, 8);
                        if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                        {
                            buttonList[value].text = GetComputerSide();
                            buttonList[value].GetComponentInParent<Button>().interactable = false;
                            EndTurn();
                        }
                    }

                }
                else if (buttonList[1].text == playerSide && buttonList[4].text == playerSide)
                {
                    value = 7;
                    if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                    {
                        buttonList[value].text = GetComputerSide();
                        buttonList[value].GetComponentInParent<Button>().interactable = false;
                        EndTurn();
                    }
                    else
                    {
                        value = Random.Range(0, 8);
                        if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                        {
                            buttonList[value].text = GetComputerSide();
                            buttonList[value].GetComponentInParent<Button>().interactable = false;
                            EndTurn();
                        }
                    }

                }
                else if (buttonList[7].text == playerSide && buttonList[4].text == playerSide)
                {
                    value = 1;
                    if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                    {
                        buttonList[value].text = GetComputerSide();
                        buttonList[value].GetComponentInParent<Button>().interactable = false;
                        EndTurn();
                    }
                    else
                    {
                        value = Random.Range(0, 8);
                        if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                        {
                            buttonList[value].text = GetComputerSide();
                            buttonList[value].GetComponentInParent<Button>().interactable = false;
                            EndTurn();
                        }
                    }

                }
                else if (buttonList[2].text == playerSide && buttonList[5].text == playerSide)
                {
                    value = 8;
                    if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                    {
                        buttonList[value].text = GetComputerSide();
                        buttonList[value].GetComponentInParent<Button>().interactable = false;
                        EndTurn();
                    }
                    else
                    {
                        value = Random.Range(0, 8);
                        if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                        {
                            buttonList[value].text = GetComputerSide();
                            buttonList[value].GetComponentInParent<Button>().interactable = false;
                            EndTurn();
                        }
                    }

                }
                else if (buttonList[8].text == playerSide && buttonList[5].text == playerSide)
                {
                    value = 2;
                    if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                    {
                        buttonList[value].text = GetComputerSide();
                        buttonList[value].GetComponentInParent<Button>().interactable = false;
                        EndTurn();
                    }
                    else
                    {
                        value = Random.Range(0, 8);
                        if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                        {
                            buttonList[value].text = GetComputerSide();
                            buttonList[value].GetComponentInParent<Button>().interactable = false;
                            EndTurn();
                        }
                    }

                }
                else if (buttonList[0].text == playerSide && buttonList[4].text == playerSide)
                {
                    value = 8;
                    if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                    {
                        buttonList[value].text = GetComputerSide();
                        buttonList[value].GetComponentInParent<Button>().interactable = false;
                        EndTurn();
                    }
                    else
                    {
                        value = Random.Range(0, 8);
                        if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                        {
                            buttonList[value].text = GetComputerSide();
                            buttonList[value].GetComponentInParent<Button>().interactable = false;
                            EndTurn();
                        }
                    }

                }
                else if (buttonList[8].text == playerSide && buttonList[4].text == playerSide)
                {
                    value = 0;
                    if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                    {
                        buttonList[value].text = GetComputerSide();
                        buttonList[value].GetComponentInParent<Button>().interactable = false;
                        EndTurn();
                    }
                    else
                    {
                        value = Random.Range(0, 8);
                        if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                        {
                            buttonList[value].text = GetComputerSide();
                            buttonList[value].GetComponentInParent<Button>().interactable = false;
                            EndTurn();
                        }
                    }

                }
                else if (buttonList[6].text == playerSide && buttonList[4].text == playerSide)
                {
                    value = 2;
                    if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                    {
                        buttonList[value].text = GetComputerSide();
                        buttonList[value].GetComponentInParent<Button>().interactable = false;
                        EndTurn();
                    }
                    else
                    {
                        value = Random.Range(0, 8);
                        if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                        {
                            buttonList[value].text = GetComputerSide();
                            buttonList[value].GetComponentInParent<Button>().interactable = false;
                            EndTurn();
                        }
                    }

                }
                else if (buttonList[2].text == playerSide && buttonList[4].text == playerSide)
                {
                    value = 6;
                    if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                    {
                        buttonList[value].text = GetComputerSide();
                        buttonList[value].GetComponentInParent<Button>().interactable = false;
                        EndTurn();
                    }
                    else
                    {
                        value = Random.Range(0, 8);
                        if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                        {
                            buttonList[value].text = GetComputerSide();
                            buttonList[value].GetComponentInParent<Button>().interactable = false;
                            EndTurn();
                        }
                    }

                }
                else
                {
                    value = Random.Range(0, 8);
                    if (buttonList[value].GetComponentInParent<Button>().interactable == true)
                    {
                        buttonList[value].text = GetComputerSide();
                        buttonList[value].GetComponentInParent<Button>().interactable = false;
                        EndTurn();
                    }
                }
            }
        }
    }

    void SetGameController1ReferenceOnButtons()
    {
        for (int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].GetComponentInParent<HardGrid>().SetGameController1Reference(this);
        }
    }

    public void SetStartingSide(string startingSide)
    {
        playerSide = startingSide;
        if (playerSide == "X")
        {
            computerSide = "O";
            SetPlayerColors(playerX, playerO);
        }
        else
        {
            computerSide = "X";
            SetPlayerColors(playerO, playerX);
        }

        StartGame();
    }

    void StartGame()
    {
        SetBoardInteractable(true);
        SetPlayerButtons(false);
        startInfo.SetActive(false);
    }

    public string GetPlayerSide()
    {
        return playerSide;
    }

    public string GetComputerSide()
    {
        return computerSide;
    }

    public void EndTurn()
    {
        moveCount++;

        for (int i = 0; i < buttonList.Length; i++)
        {
            if (buttonList[0].text == playerSide && buttonList[1].text == playerSide && buttonList[2].text == playerSide)
            {
                GameOver(playerSide);
            }

            else if (buttonList[3].text == playerSide && buttonList[4].text == playerSide && buttonList[5].text == playerSide)
            {
                GameOver(playerSide);
            }

            else if (buttonList[6].text == playerSide && buttonList[7].text == playerSide && buttonList[8].text == playerSide)
            {
                GameOver(playerSide);
            }

            else if (buttonList[0].text == playerSide && buttonList[4].text == playerSide && buttonList[8].text == playerSide)
            {
                GameOver(playerSide);
            }

            else if (buttonList[2].text == playerSide && buttonList[4].text == playerSide && buttonList[6].text == playerSide)
            {
                GameOver(playerSide);
            }

            else if (buttonList[0].text == playerSide && buttonList[3].text == playerSide && buttonList[6].text == playerSide)
            {
                GameOver(playerSide);
            }

            else if (buttonList[1].text == playerSide && buttonList[4].text == playerSide && buttonList[7].text == playerSide)
            {
                GameOver(playerSide);
            }

            else if (buttonList[2].text == playerSide && buttonList[5].text == playerSide && buttonList[8].text == playerSide)
            {
                GameOver(playerSide);
            }

            else if (buttonList[0].text == computerSide && buttonList[1].text == computerSide && buttonList[2].text == computerSide)
            {
                GameOver(computerSide);
            }

            else if (buttonList[3].text == computerSide && buttonList[4].text == computerSide && buttonList[5].text == computerSide)
            {
                GameOver(computerSide);
            }

            else if (buttonList[6].text == computerSide && buttonList[7].text == computerSide && buttonList[8].text == computerSide)
            {
                GameOver(computerSide);
            }

            else if (buttonList[0].text == computerSide && buttonList[4].text == computerSide && buttonList[8].text == computerSide)
            {
                GameOver(computerSide);
            }

            else if (buttonList[2].text == computerSide && buttonList[4].text == computerSide && buttonList[6].text == computerSide)
            {
                GameOver(computerSide);
            }

            else if (buttonList[0].text == computerSide && buttonList[3].text == computerSide && buttonList[6].text == computerSide)
            {
                GameOver(computerSide);
            }

            else if (buttonList[1].text == computerSide && buttonList[4].text == computerSide && buttonList[7].text == computerSide)
            {
                GameOver(computerSide);
            }

            else if (buttonList[2].text == computerSide && buttonList[5].text == computerSide && buttonList[8].text == computerSide)
            {
                GameOver(computerSide);
            }

            else if (moveCount >= 9)
            {
                GameOver("draw");
            }
            else
            {
                ChangeSides();
                delay = 10;
            }
        }

    }

    void ChangeSides()
    {
        //playerSide = (playerSide == "X") ? "O" : "X";
        playerMove = (playerMove == true) ? false : true;
        //if(playerSide == "X")
        if (playerMove == true)
        {
            Cursor.visible = true;
            SetPlayerColors(playerX, playerO);
        }
        else
        {
            Cursor.visible = false;
            SetPlayerColors(playerO, playerX);
        }
    }

    void SetPlayerColors(Player newPlayer, Player oldPlayer)
    {
        newPlayer.panel.color = activePlayerColor.panelColor;
        newPlayer.text.color = activePlayerColor.textColor;

        oldPlayer.panel.color = inactivePlayerColor.panelColor;
        oldPlayer.text.color = inactivePlayerColor.textColor;
    }

    void GameOver(string winningPlayer)
    {
        SetBoardInteractable(false);
        if (winningPlayer == "draw")
        {
            SetGameOverText("Draw");
            SetPlayerColorsInactive();
        }
        else
        {
            SetGameOverText(winningPlayer + " wins");
            SetPlayerColorsInactive();
        }
        restartButton.SetActive(true);
        Cursor.visible = true;
    }

    void SetGameOverText(string value)
    {
        gameOverPanel.SetActive(true);
        gameOverText.text = value;
    }

    public void RestartGame()
    {
        moveCount = 0;
        gameOverPanel.SetActive(false);
        restartButton.SetActive(false);
        SetPlayerButtons(true);
        startInfo.SetActive(true);
        SetPlayerColorsInactive();
        playerMove = true;
        delay = 10;

        for (int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].text = "";
        }
    }

    void SetBoardInteractable(bool toggle)
    {
        for (int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].GetComponentInParent<Button>().interactable = toggle;
        }
    }

    void SetPlayerButtons(bool toggle)
    {
        playerX.button.interactable = toggle;
        playerO.button.interactable = toggle;
    }

    void SetPlayerColorsInactive()
    {
        playerX.panel.color = inactivePlayerColor.panelColor;
        playerX.text.color = inactivePlayerColor.textColor;
        playerO.panel.color = inactivePlayerColor.panelColor;
        playerO.panel.color = inactivePlayerColor.textColor;
    }
}