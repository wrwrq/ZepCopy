using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoinButton : MonoBehaviour
{
    [SerializeField]Text _nameText;

    public void CanJoin()
    {
        if (_nameText.text.Length < (int)NameLimit.MaxName && _nameText.text.Length > (int)NameLimit.MinName)
        {
            GameManager.gameManager.EndSetting(_nameText.text);
        }
    }
}
