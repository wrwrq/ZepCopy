using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput2D : PlayerCallScripts
{
    void OnMove(InputValue value)
    {
        CallMove(value.Get<Vector2>().normalized);
    }
}
