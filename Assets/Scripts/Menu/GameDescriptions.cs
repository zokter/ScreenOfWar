using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameDescriptions
{

    private static string[] gameDescriptions = {
        "A game where you and your opponent tap the screen as fast as you can and whoever fills the screen first wins.",
        "A ping pong simulator from the beginning of the video game era that can still be fun.",
    };

    public static string getDescription(int index)
    {
        return gameDescriptions[index];
    }
}
