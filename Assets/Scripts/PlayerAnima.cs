using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnima : MonoBehaviour
{
    public enum Character
    {
        ad,nin
    }
    PlayerCallScripts _playerCall;
    Animator _ani;
    bool _isWalk = false;
    private void Awake()
    {
        _playerCall = GetComponent<PlayerCallScripts>();
        _ani = GetComponentInChildren<Animator>();
    }
    private void Start()
    {
        _playerCall.OnMoveEvent += Walk;
    }
    private void Update()
    {
        if (transform.position.x > Camera.main.ScreenToWorldPoint(Input.mousePosition).x)
        {
            GetComponentInChildren<SpriteRenderer>().flipX = true;
        }
        else if (transform.position.x < Camera.main.ScreenToWorldPoint(Input.mousePosition).x)
        {
            GetComponentInChildren<SpriteRenderer>().flipX = false;
        }
        WalkAnima();
    }
    void Walk(Vector2 direction)
    {
        if (direction == Vector2.zero)
        {
            _isWalk = false;
        }
        else
        {
            _isWalk = true;
        }
    }
    void WalkAnima()
    {
        _ani.SetBool("isWalk",_isWalk);
    }
    public void CharacterChange(Character form)
    {
        _ani.runtimeAnimatorController = (RuntimeAnimatorController)Resources.Load(form.ToString());
    }
}
