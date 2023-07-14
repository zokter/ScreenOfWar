using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueController : MonoBehaviour
{
    public void Move()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - Coordinates.deltaMovement, transform.position.z);
    }


    public void MoveBack()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + Coordinates.deltaMovement, transform.position.z);
    }
}
