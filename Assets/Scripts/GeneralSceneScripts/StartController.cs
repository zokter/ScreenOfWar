using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartController : MonoBehaviour
{
    [SerializeField] MonoBehaviour[] controlScripts;
    [SerializeField] GameObject startButton;
    [SerializeField] GameObject pauseButton;

    private void Awake()
    {
        startButton.SetActive(true);
        pauseButton.SetActive(false);
        for (int i = 0; i < controlScripts.Length; i++)
        {
            controlScripts[i].enabled = false;
        }
    }

    public void StartGame()
    {
        startButton.SetActive(false);
        pauseButton.SetActive(true);
        for (int i = 0; i < controlScripts.Length; i++)
        {
            controlScripts[i].enabled = true;
        }
    }
}
