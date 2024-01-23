using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCallScripts : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public void CallMove(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }
}
