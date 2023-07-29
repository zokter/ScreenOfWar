using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    
    [SerializeField] MonoBehaviour[] controlScripts;
    [SerializeField] GameObject startButton;
    [SerializeField] GameObject pauseButton;

    public void PauseGame()
    {
        startButton.SetActive(true);
        pauseButton.SetActive(false);
        for (int i = 0; i < controlScripts.Length; i++)
        {
            controlScripts[i].enabled = false;
        }
    }
}
