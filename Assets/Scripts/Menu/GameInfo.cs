using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfo
{
    private Sprite GameIco;
    private int GameSceneNumber;
    private string GameName;
    private string GameDescription;

    public GameInfo(Sprite Ico, int SceneNumber, string Name, string Description)
    {
        GameIco = Ico;
        GameSceneNumber = SceneNumber;
        GameName = Name;
        GameDescription = Description;
    }

    public Sprite GetGameIco()
    {
        return GameIco;
    }

    public int GetGameSceneNumber()
    {
        return GameSceneNumber;
    }

    public string GetGameName()
    {
        return GameName;
    }

    public string GetGameDescription()
    {
        return GameDescription;
    }
}
