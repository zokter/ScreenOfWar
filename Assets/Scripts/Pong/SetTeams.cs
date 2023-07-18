using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTeams : MonoBehaviour
{
    [SerializeField] private GameObject RedTeam;
    [SerializeField] private GameObject BlueTeam;

    [SerializeField] private GameObject RedRacket;
    [SerializeField] private GameObject BlueRacket;

    [SerializeField] private GameObject Ball;

    void Start()
    {
        RedTeam.transform.position = new Vector3(0, Coordinates.top / 2);
        BlueTeam.transform.position = new Vector3(0, Coordinates.bottom / 2);

        RedTeam.transform.localScale = new Vector3(Coordinates.right - Coordinates.left, Coordinates.top, 1);
        BlueTeam.transform.localScale = new Vector3(Coordinates.right - Coordinates.left, Coordinates.top, 1);

        RedRacket.transform.position = new Vector3(0, Coordinates.top - Coordinates.top / 5);
        BlueRacket.transform.position = new Vector3(0, Coordinates.bottom + Coordinates.top / 5);

        RedRacket.transform.localScale = new Vector3((Coordinates.right - Coordinates.left) / 8, Coordinates.top / 50, 1);
        BlueRacket.transform.localScale = new Vector3((Coordinates.right - Coordinates.left) / 8, Coordinates.top / 50, 1);

        Ball.transform.localScale = new Vector3(Coordinates.top / 30, Coordinates.top / 30);
    }
}
