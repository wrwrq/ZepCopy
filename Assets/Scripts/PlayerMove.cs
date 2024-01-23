using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    PlayerCallScripts _playerCall;
    Rigidbody2D _rigi;
    Vector2 _direction;
    [SerializeField] float speed;
    private void Awake()
    {
        _rigi = GetComponent<Rigidbody2D>();
        _playerCall = GetComponent<PlayerCallScripts>();
    }
    private void Start()
    {
        _playerCall.OnMoveEvent += Move;
    }
    private void FixedUpdate()
    {
        MoveLogic();
    }
    void Move(Vector2 direction)
    {
        _direction = direction;
    }
    void MoveLogic()
    {
        _rigi.velocity = speed * _direction;
    }
}
