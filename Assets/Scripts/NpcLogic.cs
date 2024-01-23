using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


public class NpcLogic : MonoBehaviour
{
    public string _name;
    public bool isTalking = true;
    [Serializable]
    public struct History
    {
        public Sprite whoface;
        public string who;
        public string speak;
    }
    [SerializeField] History[] history;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && isTalking)
        {
            isTalking = false;
            DialogManager.dialogmanager.CallTalk(history);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag =="Player")
        {
            isTalking = true;
        }
    }

    private void OnEnable()
    {
        NpcList.npcs.Add(this);
    }
    void OnDisable()
    {
        NpcList.npcs.Remove(this);
    }
}
