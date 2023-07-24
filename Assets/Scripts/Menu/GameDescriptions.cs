using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameDescriptions
{

    private static string[] gameDescriptions = {
        "Screen of war",
        "Pong",
    };

    public static string getDescriptions(int index)
    {
        return gameDescriptions[index];
    }
}
