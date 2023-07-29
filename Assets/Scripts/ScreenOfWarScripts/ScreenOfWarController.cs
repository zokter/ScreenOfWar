using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenOfWarController : MonoBehaviour
{
    [SerializeField] private GameObject Red;
    [SerializeField] private GameObject Blue;

    RedController RC;
    BlueController BC;

    WinController WinController;

    private void Awake()
    {
        RC = Red.GetComponent<RedController>();
        BC = Blue.GetComponent<BlueController>();
        WinController = GetComponent<WinController>();
    }

    private void Update()
    {
#if UNITY_ANDROID || UNITY_IPHONE
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                if (raycastHit.transform.name == "Red")
                {
                    RC.Move();
                    BC.MoveBack();
                }
                else if (raycastHit.transform.name == "Blue")
                {
                    BC.Move();
                    RC.MoveBack();
                }
            }
        }
#endif
#if UNITY_STANDALONE_WIN
        Vector3 mousePos = Input.mousePosition;
        if (Input.GetMouseButtonDown(0))
        {
            Ray raycast = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                if (raycastHit.transform.name == "Red")
                {
                    RC.Move();
                    BC.MoveBack();
                }
                else if (raycastHit.transform.name == "Blue")
                {
                    BC.Move();
                    RC.MoveBack();
                }
            }
        }
#endif
        if(Red.transform.position.y  == 0)
        {
            WinController.OneSideWon(0);
        }
        if(Blue.transform.position.y == 0)
        {
            WinController.OneSideWon(1);
        }
    }
}
