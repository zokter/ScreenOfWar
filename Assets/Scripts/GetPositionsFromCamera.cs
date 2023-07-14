using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPositionsFromCamera : MonoBehaviour
{

    private Camera cam;
    private Vector3 leftUpCorner;
    private Vector3 rightBottomCorner;


    private void Awake()
    {

        cam = Camera.main;

        leftUpCorner = cam.ScreenToWorldPoint(new Vector3(0, cam.scaledPixelHeight, 1));
        rightBottomCorner = cam.ScreenToWorldPoint(new Vector3(cam.scaledPixelWidth, 0, 1));

        Coordinates.top = leftUpCorner.y;
        Coordinates.bottom = rightBottomCorner.y;
        Coordinates.left = leftUpCorner.x;
        Coordinates.right = rightBottomCorner.x;
        Coordinates.deltaMovement = (Coordinates.bottom - Coordinates.top) / 10;
    }
}
