using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCheck
{
    public static bool IsOnBounds(Transform tf, float moveDirection)
    {
        if (tf.position.x + tf.localScale.x / 2 >= Coordinates.right && moveDirection > 0)
        {
            return true;
        }
        if (tf.position.x - tf.localScale.x / 2 <= Coordinates.left && moveDirection < 0)
        {
            return true;
        }
        return false;
    }
}
