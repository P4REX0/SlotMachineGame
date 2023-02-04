using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI ResultTxt;
    public Button button;
 
    public List<string> finalprize;
    public bool isPlaying;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();

        if (finalprize.Count == 3)
        {
            if (isPlaying) return;
            if (finalprize[0] == finalprize[1] && finalprize[1] == finalprize[2])
            {
                print("You Won");
                ResultTxt.text = "Win";
                isPlaying = true;
            }
            else
            {
                print("You Lose");
                ResultTxt.text = "Lose";
                isPlaying = true;
            }
        }
        else
            ResultTxt.text = "";

    }
}
