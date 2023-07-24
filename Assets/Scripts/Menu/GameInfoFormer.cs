using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInfoFormer : MonoBehaviour
{
    private int GamesCount;
    [SerializeField] private GameObject menuContainer;
    private GameObject Menu;

    [SerializeField] private Sprite[] GameIcons;
    private void Awake()
    {
        Menu = transform.GetChild(0).GetChild(0).gameObject;
        GamesCount = SceneManager.sceneCountInBuildSettings;
        for(int i = 1; i < GamesCount; i++)
        {
            GameInfo GameToAdd = new GameInfo(GameIcons[0], i, GameNames.getName(i - 1), GameDescriptions.getDescriptions(i - 1));
            GameObject container = Instantiate(menuContainer, Menu.transform);
            container.GetComponent<ContainerManager>().SetGameInfo(GameToAdd);
        }
    }
}
