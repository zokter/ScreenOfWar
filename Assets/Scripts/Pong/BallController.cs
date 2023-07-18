using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float moveSpeedCup = 8;

    private WinController winController;

    private ScoreTextController scoreTextController;

    private float startMoveSpeed = 1.0f;

    private float moveSpeed;

    private Vector2 direction;

    private bool team;

    private void Awake()
    {
        moveSpeed = startMoveSpeed;

        scoreTextController = GetComponentInParent<ScoreTextController>();
        winController = GetComponentInParent<WinController>();

        System.Random rnd = new System.Random();
        team = rnd.Next(2) == 1;
        if(team == true)
        {
            direction = new Vector2(0.0f, 1.0f) * -1;
        }
        else
        {
            direction = new Vector2(0.0f, 1.0f);
        }
    }


    void FixedUpdate()
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime);
        if (PositionCheck.IsOnBounds(transform, direction.x))
        {
            direction = new Vector2(-direction.x, direction.y);
        }

        if(transform.position.y > Coordinates.top)
        {
            PongScore.BlueGoalsCount++;
            scoreTextController.BlueScore.text = PongScore.BlueGoalsCount.ToString();
            ResetAfterGoal(1);
        }
        else if(transform.position.y < Coordinates.bottom)
        {
            PongScore.RedGoalsCount++;
            scoreTextController.RedScore.text = PongScore.RedGoalsCount.ToString();
            ResetAfterGoal(-1);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        float cathetus_a = transform.position.y - collision.transform.position.y;
        float cathetus_b = transform.position.x - collision.transform.position.x;

        direction = new Vector2(cathetus_b, cathetus_a).normalized;
        if(moveSpeed < moveSpeedCup)
        {
            moveSpeed++;
        }
    }

    private void ResetAfterGoal(int scoringTeam)
    {
        transform.position = new Vector2(0, 0);
        direction = new Vector2(0.0f, 1.0f) * scoringTeam;
        moveSpeed = startMoveSpeed;

        if(PongScore.RedGoalsCount >= 10)
        {
            winController.OneSideWon(0);
            PongScore.BlueGoalsCount = 0;
            PongScore.RedGoalsCount = 0;
        }
        else if(PongScore.BlueGoalsCount >= 10)
        {
            winController.OneSideWon(1);
            PongScore.BlueGoalsCount = 0;
            PongScore.RedGoalsCount = 0;
        } 
    }
}
