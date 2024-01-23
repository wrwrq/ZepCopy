using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChangeButton : MonoBehaviour
{
    [SerializeField] GameObject _selectPanel;
    [SerializeField]bool isRight;
    public void ChoiceCharacter()
    {
        if (isRight)
        {
            GameManager.gameManager.SettingCharacter(PlayerAnima.Character.nin);
            _selectPanel.SetActive(false);
            return;
        }
        GameManager.gameManager.SettingCharacter(PlayerAnima.Character.ad);
        _selectPanel.SetActive(false);
    }
}
