using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using static NpcLogic;

public class DialogManager : MonoBehaviour
{
    [SerializeField] GameObject dialogCnvas;
    [SerializeField] GameObject talkerImage;
    [SerializeField] Text someTalk;
    [SerializeField] Text nameSpace;
    [SerializeField] GameObject settingUi;
    public static DialogManager dialogmanager;
    private void Awake()
    {
        if (dialogmanager == null)
        {
            dialogmanager = this;
        }
        else
        {
            Destroy(this);
        }
    }
    public void CallTalk(params NpcLogic.History[] history)
    {
        StartCoroutine(TalkStart(history));
    }
    IEnumerator TalkStart(params NpcLogic.History[] history)
    {
        dialogCnvas.SetActive(true);
        settingUi.SetActive(false);
        GameManager.gameManager._player.GetComponent<PlayerInput>().enabled = false;

        for (int i = 0; i < history.Length; i++)
        {
            if (history[i].who == "_p")
            {
                talkerImage.GetComponent<Image>().sprite = GameManager.gameManager._player.GetComponentInChildren<SpriteRenderer>().sprite; //idle 0번째로 고정하는것도..
                nameSpace.text = GameManager.gameManager._player.GetComponentInChildren<Text>().text;
            }
            else
            {
                talkerImage.GetComponent<Image>().sprite = history[i].whoface;
                nameSpace.text = history[i].who;
            }
            someTalk.text = history[i].speak;
            yield return new WaitForSeconds(1f);
            yield return new WaitUntil(() => Input.anyKeyDown);
            if (i == history.Length - 1)
            {
                dialogCnvas.SetActive(false);
                settingUi.SetActive(true);
                GameManager.gameManager._player.GetComponent<PlayerInput>().enabled = true;
                yield break;
            }
        }
    }
}
