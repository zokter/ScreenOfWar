using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameNames
{
    private static string[] gameNames = {
        "Screen of war",
        "Pong",
    };

    public static string getName(int index)
    {
        return gameNames[index];
    }
}
