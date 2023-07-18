using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketsController : MonoBehaviour
{
    [SerializeField] private Transform RedRacket;
    [SerializeField] private Transform BlueRacket;

    private float speedModifier = 0.003f;

    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    void FixedUpdate()
    {
        if(Input.touchCount > 0)
        {
            for(int i = 0; i < Input.touchCount; i++)
            {
                Touch touch = Input.GetTouch(i);
                Ray rayCast = cam.ScreenPointToRay(touch.position);
                RaycastHit hit;
                if (Physics.Raycast(rayCast, out hit))
                {
                    if (hit.transform.name == "RedTeam")
                    {
                        if (!PositionCheck.IsOnBounds(RedRacket.transform, touch.deltaPosition.x))
                        {
                            RedRacket.transform.position = new Vector2(RedRacket.transform.position.x + touch.deltaPosition.x * speedModifier,
                                RedRacket.transform.position.y);
                        }
                        else
                        {
                            if (RedRacket.transform.position.x > 0)
                            {
                                RedRacket.transform.position = new Vector2(Coordinates.right - RedRacket.transform.localScale.x / 2, 
                                                                           RedRacket.transform.position.y);
                            }
                            else
                            {
                                RedRacket.transform.position = new Vector2(Coordinates.left + RedRacket.transform.localScale.x / 2, 
                                                                           RedRacket.transform.position.y);
                            }
                        }

                    }
                    if (hit.transform.name == "BlueTeam")
                    {
                        if (!PositionCheck.IsOnBounds(BlueRacket.transform, touch.deltaPosition.x))
                        {
                            BlueRacket.transform.position = new Vector2(BlueRacket.transform.position.x + touch.deltaPosition.x * speedModifier,
                                                                        BlueRacket.transform.position.y);
                        }
                        else
                        {
                            if (BlueRacket.transform.position.x > 0)
                            {
                                BlueRacket.transform.position = new Vector2(Coordinates.right - BlueRacket.transform.localScale.x / 2, 
                                                                            BlueRacket.transform.position.y);
                            }
                            else
                            {
                                BlueRacket.transform.position = new Vector2(Coordinates.left + BlueRacket.transform.localScale.x / 2, 
                                                                            BlueRacket.transform.position.y);
                            }
                        }
                    }
                }
            }
        }
    }
}
