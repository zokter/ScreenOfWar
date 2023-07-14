using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeTeams : MonoBehaviour
{
    [SerializeField] GameObject Red;
    [SerializeField] GameObject Blue;

    private void Start()
    {
        Red.transform.position = new Vector3(0, Coordinates.top, 1);
        Blue.transform.position = new Vector3(0, Coordinates.bottom, 1);

        Red.transform.localScale = new Vector3(Coordinates.right - Coordinates.left, Coordinates.top - Coordinates.bottom, 1);
        Blue.transform.localScale = new Vector3(Coordinates.right - Coordinates.left, Coordinates.top - Coordinates.bottom, 1);
    }
}
