using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{
    [SerializeField] MonoBehaviour[] controlScripts;
    [SerializeField] GameObject startButton;

    private void Awake()
    {
        startButton.SetActive(true);
        for (int i = 0; i < controlScripts.Length; i++)
        {
            controlScripts[i].enabled = false;
        }
    }

    public void StartGame()
    {
        startButton.SetActive(false);
        for (int i = 0; i < controlScripts.Length; i++)
        {
            controlScripts[i].enabled = true;
        }
    }
}
