using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameChangeButton : MonoBehaviour
{
    [SerializeField] GameObject nameChangePopUp;
    [SerializeField] Text newName;

    public void SettingName()
    {
        if (newName.text.Length < (int)NameLimit.MaxName && newName.text.Length > (int)NameLimit.MinName)
        {
            GameManager.gameManager._player.GetComponentInChildren<Text>().text = newName.text;
            UserListPanel.ReSetPlayerName();
            nameChangePopUp.SetActive(false);
        }
    }
}
