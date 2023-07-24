using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContainerManager : MonoBehaviour
{
    private Image icon;
    private TextMeshProUGUI TMPName;
    private TextMeshProUGUI TMPDescription;
    private int sceneIndex;

    public void SetGameInfo(GameInfo Info)
    {
        icon = transform.GetChild(0).GetComponent<Image>();
        TMPName = transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>();
        TMPDescription = transform.GetChild(1).GetChild(1).GetComponent<TextMeshProUGUI>();

        sceneIndex = Info.GetGameSceneNumber();
        icon.sprite = Info.GetGameIco();
        TMPName.text = Info.GetGameName();
        TMPDescription.text = Info.GetGameDescription();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
