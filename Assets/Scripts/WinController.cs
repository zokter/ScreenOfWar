using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class WinController : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private Button restartButton;
    private TextController textController;

    [SerializeField] private TextMeshProUGUI RedWinsCount;
    [SerializeField] private TextMeshProUGUI BlueWinsCount;

    [SerializeField] private Image RedCountBackground;
    [SerializeField] private Image BlueCountBackground;

    [SerializeField] private MonoBehaviour[] controllScripts;

    private void Awake()
    {
        textController = canvas.GetComponent<TextController>();
        restartButton.enabled = false;
        RedWinsCount.enabled = false;
        BlueWinsCount.enabled = false;
        RedCountBackground.enabled = false;
        BlueCountBackground.enabled = false;
    }

    public void OneSideWon(int side)
    {
        if(side == 0)
        {
            textController.SetText("Red won!");
            PlayerScore.RedWinsCount += 1;
        }
        else
        {
            textController.SetText("Blue won!");
            PlayerScore.BlueWinsCount += 1;
        }

        RedWinsCount.text = PlayerScore.RedWinsCount.ToString();
        BlueWinsCount.text = PlayerScore.BlueWinsCount.ToString();

        for(int i = 0; i < controllScripts.Length; i++)
        {
            controllScripts[i].enabled = false;
        }
        restartButton.enabled = true;
        RedWinsCount.enabled = true;
        BlueWinsCount.enabled = true;
        RedCountBackground.enabled = true;
        BlueCountBackground.enabled = true;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
